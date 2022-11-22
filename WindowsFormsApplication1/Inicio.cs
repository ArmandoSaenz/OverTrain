using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication1.Properties;
using WindowsFormsApplication1.Properties;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApplication1.Models;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        static bool ClientLoop = true;
        public string Message { get; set; }
        public enum SynchronousStatus { Initialize, Download, Upload, Insert, Update, Comparing, None};
        static public SynchronousStatus Status { get; set; }
        Stopwatch reloj = new Stopwatch();
        public void ShowMessage()
        {
            tsslCloud.Text = String.Concat(reloj.Elapsed.ToString()," ",Message);
        }
        private void SaveError(Exception err)
        {
            if (File.Exists("log.err"))
                File.AppendAllText("log.err", DateTime.Now.ToString("D") + ":" + err.Message + Environment.NewLine);
            else
                File.WriteAllText("log.err", DateTime.Now.ToString("D") + ":" + err.Message + Environment.NewLine);
        }
        private void Sincronizar() 
        {
            reloj.Start();
            Inicio.Status = SynchronousStatus.Initialize;
            Message = "Inicializando";
            this.Invoke(new Action(ShowMessage));
            LinkRemote linkRemote = new LinkRemote();
            Link linkLocal = new Link();
            Models.LinkRemoteTableAdapters.cli00TableAdapter RemoteCli00Adapter = new Models.LinkRemoteTableAdapters.cli00TableAdapter();
            Models.LinkRemoteTableAdapters.cli00IndexTableAdapter RemoteCli00IndexAdapter = new Models.LinkRemoteTableAdapters.cli00IndexTableAdapter();
            LinkTableAdapters.cli00TableAdapter LocalCli00Adapter = new LinkTableAdapters.cli00TableAdapter();
            LinkTableAdapters.cli00IndexTableAdapter LocalCli00IndexAdapter = new LinkTableAdapters.cli00IndexTableAdapter();
            Link.cli00Row LocalCli = null;
            LinkRemote.cli00Row RemoteCli = null;
            List<int> RemoteClients = null;
            List<int> LocalClients = null;
            List<int> MissingClients = null;
            while (Inicio.ClientLoop)
            {
                try
                {
                    Inicio.Status = SynchronousStatus.Download;
                    Message = "Buscando ID' faltantes";
                    this.Invoke(new Action(ShowMessage));
                    RemoteCli00IndexAdapter.Fill(linkRemote.cli00Index);
                    LocalCli00IndexAdapter.Fill(linkLocal.cli00Index);
                    RemoteClients = Utilities.Table2List.ConverToList(linkRemote.cli00Index);
                    LocalClients = Utilities.Table2List.ConverToList(linkLocal.cli00Index);
                    MissingClients = RemoteClients.FindAll(remoteid => !LocalClients.Contains(remoteid));
                }
                catch (Exception err)
                {
                    SaveError(err);
                    goto delay;
                }
                if (MissingClients.Count == 0)
                {
                    Inicio.Status = SynchronousStatus.Download;
                    Message = "Todos los clientes estan decargados";
                    this.Invoke(new Action(ShowMessage));
                    System.Threading.Thread.Sleep(10000);
                }
                else
                {
                    foreach (int missingClient in MissingClients)
                    {
                        Inicio.Status = SynchronousStatus.Insert;
                        Message = "Insertando el cliente " + missingClient.ToString();
                        this.Invoke(new Action(ShowMessage));
                        try
                        {
                            if (RemoteCli00Adapter.FillByID(linkRemote.cli00, missingClient) > 0)
                                RemoteCli = linkRemote.cli00[0];
                            else
                                continue;
                        }
                        catch (Exception err)
                        {
                            SaveError(err);
                            Message = "Error insertando el cliente " + missingClient.ToString();
                            this.Invoke(new Action(ShowMessage));
                            System.Threading.Thread.Sleep(3000);
                        }
                        try 
                        {
                            LocalCli00Adapter.Insert(RemoteCli.ncli,
                                                        RemoteCli.IsdirNull() ? "" : RemoteCli.dir,
                                                        RemoteCli.IstelefonoNull() ? "" : RemoteCli.telefono,
                                                        RemoteCli.IsobsNull() ? "" : RemoteCli.obs,
                                                        RemoteCli.IshuellaNull() ? null : RemoteCli.huella,
                                                        RemoteCli.IsfotoNull() ? null : RemoteCli.foto,
                                                        RemoteCli.IsFLimiteNull() ? DateTime.Now.AddDays(-1) : RemoteCli.FLimite,
                                                        Convert.ToByte(RemoteCli.area1),
                                                        Convert.ToByte(RemoteCli.area2),
                                                        Convert.ToByte(RemoteCli.area3),
                                                        RemoteCli.IsempresaNull() ? "" : RemoteCli.empresa,
                                                        RemoteCli.IsfechapagoNull() ? DateTime.Now.AddDays(-1) : RemoteCli.fechapago,
                                                        RemoteCli.id,
                                                        DateTime.Now);
                            Message = "Cliente " + missingClient.ToString() + " insertado";
                            this.Invoke(new Action(ShowMessage));
                            System.Threading.Thread.Sleep(3000);
                        }
                        catch (Exception err)
                        {
                            SaveError(err);

                        }
                        if (!Inicio.ClientLoop)
                            return;
                    }
                }
                foreach(Link.cli00Row client in linkLocal.cli00.TakeWhile(reg => reg.id < 0))
                {
                    Message = "Subiendo cliente " + client.idcli.ToString();
                    this.Invoke(new Action(ShowMessage));
                    RemoteCli00Adapter.Insert(  client.idcli,
                                                client.ncli,
                                                client.IsdirNull() ? "" : client.dir,
                                                client.IstelefonoNull() ? "" : client.telefono,
                                                client.IsobsNull() ? "" : client.obs,
                                                client.IshuellaNull() ? null : client.huella,
                                                client.IsfotoNull() ? null : client.foto,
                                                client.IsFLimiteNull() ? DateTime.Now.AddDays(-1) : client.FLimite,
                                                client.IsfechapagoNull() ? DateTime.Now.AddDays(-1): client.fechapago,
                                                Convert.ToByte(client.area1),
                                                Convert.ToByte(client.area2),
                                                Convert.ToByte(client.area3),
                                                client.IsempresaNull() ? "" : client.empresa,
                                                DateTime.Now);
                    client.id = (int)RemoteCli00Adapter.Adapter.InsertCommand.LastInsertedId;
                    LocalCli00Adapter.Update(client);
                    Message = "Cliente " + client.idcli.ToString() + " subido";
                    this.Invoke(new Action(ShowMessage));
                    System.Threading.Thread.Sleep(3000);
                }
                Inicio.Status = SynchronousStatus.Comparing;
                foreach (int currentCli in RemoteClients)
                {
                    try
                    {
                        if (RemoteCli00Adapter.FillByID(linkRemote.cli00, currentCli) > 0)
                            RemoteCli = linkRemote.cli00[0];
                        else
                            continue;
                        LocalCli = linkLocal.cli00.FirstOrDefault(reg => reg.id == RemoteCli.id);
                        if (LocalCli != null)
                        {
                            if (LocalCli.FLimite < RemoteCli.FLimite)
                            {
                                Inicio.Status = SynchronousStatus.Update;
                                LocalCli.ncli = RemoteCli.ncli;
                                LocalCli.dir = RemoteCli.IsdirNull() ? "" : RemoteCli.dir;
                                LocalCli.telefono = RemoteCli.IstelefonoNull() ? "" : RemoteCli.telefono;
                                LocalCli.obs = RemoteCli.IsobsNull() ? "" : RemoteCli.obs;
                                LocalCli.huella = RemoteCli.IshuellaNull() ? null : RemoteCli.huella;
                                LocalCli.foto = RemoteCli.IsfotoNull() ? null : RemoteCli.foto;
                                LocalCli.FLimite = RemoteCli.IsFLimiteNull() ? DateTime.Now.AddDays(-1) : RemoteCli.FLimite;
                                LocalCli.fechapago = RemoteCli.IsfechapagoNull() ? DateTime.Now.AddDays(-1) : RemoteCli.fechapago;
                                LocalCli.area1 = RemoteCli.area1;
                                LocalCli.area2 = RemoteCli.area2;
                                LocalCli.area3 = RemoteCli.area3;
                                LocalCli.empresa = RemoteCli.IsempresaNull() ? "" : RemoteCli.empresa;
                                LocalCli.date_modify = RemoteCli.date_modify;
                                LocalCli00Adapter.Update(LocalCli);
                                Inicio.Status = SynchronousStatus.Comparing;
                            }
                            else if(LocalCli.FLimite > RemoteCli.FLimite)
                            {
                                Inicio.Status = SynchronousStatus.Update;
                                RemoteCli.ncli = LocalCli.ncli;
                                RemoteCli.dir = LocalCli.IsdirNull() ? "" : LocalCli.dir;
                                RemoteCli.telefono = LocalCli.IstelefonoNull() ? "" : LocalCli.telefono;
                                RemoteCli.obs = LocalCli.IsobsNull() ? "" : LocalCli.obs;
                                RemoteCli.huella = LocalCli.IshuellaNull() ? null : LocalCli.huella;
                                RemoteCli.foto = LocalCli.IsfotoNull() ? null : LocalCli.foto;
                                RemoteCli.FLimite = LocalCli.IsFLimiteNull() ? DateTime.Now.AddDays(-1) : LocalCli.FLimite;
                                RemoteCli.fechapago = LocalCli.IsfechapagoNull() ? DateTime.Now.AddDays(-1) : LocalCli.fechapago;
                                RemoteCli.area1 = LocalCli.area1;
                                RemoteCli.area2 = LocalCli.area2;
                                RemoteCli.area3 = LocalCli.area3;
                                RemoteCli.empresa = LocalCli.IsempresaNull() ? "" : LocalCli.empresa;
                                RemoteCli.date_modify = LocalCli.date_modify;
                                RemoteCli00Adapter.Update(RemoteCli);
                                Inicio.Status = SynchronousStatus.Comparing;
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        File.WriteAllText("log.err", err.Message);
                    }
                    if (!Inicio.ClientLoop)
                        return;
                }
            delay:
                Inicio.Status = SynchronousStatus.None;
                if (!Inicio.ClientLoop)
                    return;
                System.Threading.Thread.Sleep(60000);
            }
        }
        
        private Task TaskCheckClient;
        public Inicio()
        {
            InitializeComponent();
            TaskCheckClient = new Task(new Action(Sincronizar));
            TaskCheckClient.Start();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            MenuPrincipal frm = new MenuPrincipal();
            frm.ShowDialog();
            timer1.Start();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.ShowDialog();
        }


        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            if (VarPub.admin)
            {
                Precios frm = new Precios();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos de administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (VarPub.admin)
            {
                Pagos frm = new Pagos();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos de administrador","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Ventas frm = new Ventas();
            frm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Personal frm = new Personal();
            frm.ShowDialog();
        }
        string[] renglon;
        string[] fecha;
        Link.cli00Row rencli;

        private void Inicio_Load(object sender, EventArgs e)
        {
            Settings.Default["gimnasioConnectionString"] = Settings.Default.conexion;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Configuracion frm = new Configuracion();
            frm.txtPass.Enabled = false;
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Corte frm = new Corte();
            frm.ShowDialog();
        }

        private void Inicio_Shown(object sender, EventArgs e)
        {
            timer1.Stop();
            MenuPrincipal frm = new MenuPrincipal();
            frm.ShowDialog();
            timer1.Start();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Gastos frm = new Gastos();
            frm.ShowDialog();
        }

        DateTime hoy = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 11, 55, 00);
        int corte;

        private void timer1_Tick(object sender, EventArgs e)
        {
/*            try
            {
                if (DateTime.Now > hoy)
                {
                    corte = corte00TableAdapter.FillByFecha(link.corte00, DateTime.Today);
                    switch(corte)
                    {
                        case 0:
                            label1.Visible = true;
                            break;
                        case 1:
                            label1.Visible = false;
                            timer1.Stop();
                            break;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
*/
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (VarPub.admin)
            {
                CanVentas frm = new CanVentas();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos de administrador");
            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Inicio.Status == SynchronousStatus.Initialize ||Inicio.Status == SynchronousStatus.Download || Inicio.Status == SynchronousStatus.None)
            {
                return;
            }
            Inicio.ClientLoop = false;
            TaskCheckClient.Wait();
        }
    }
}