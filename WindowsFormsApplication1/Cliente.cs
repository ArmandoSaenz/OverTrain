using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Cliente : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        Datos datos = new Datos();
        byte[] huella;
        private bool nuevo;
        public Cliente()
        {
            InitializeComponent();
            datos.DataBindings.Add("Huella", cli00BindingSource, "huella");
            BuscarDispositivos();
            link.cli00.empresaColumn.DefaultValue = WindowsFormsApplication1.Properties.Settings.Default.Sucursal;
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
            {
                comboBox1.Items.Add(Dispositivos[i].Name.ToString());
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            Foto.Image = Imagen;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Camara")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[comboBox1.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    comboBox1.Enabled = false;
                    btnConectar.Text = "Detener";
                }
                else
                {
                    Estado.Text = "Error: No se encuentra dispositivo.";
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = " Dispositivo detenido";
                    btnConectar.Text = "Camara";
                    comboBox1.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!openFileDialog1.CheckFileExists)
            {
                return;
            }
            Foto.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            Template.Serialize(ref huella);
            dataGridView1.CurrentRow.Cells["cHuella"].Value = huella;
        }

        private void EnrollmentControl_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            huella = null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Foto.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cli00BindingSource.EndEdit();
            foreach(Link.cli00Row row in (link.cli00.GetChanges() as Link.cli00DataTable))
            {
                row.date_modify = DateTime.Now;
            }
            cli00TableAdapter.Update(link.cli00);
            if (nuevo)
            {
                link.cli00[cli00BindingSource.Position].idcli = (int)cli00TableAdapter.Adapter.InsertCommand.LastInsertedId;
            }
            if (MessageBox.Show("¿Deseas cargar mas información?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            cli00TableAdapter.FillByNombre(link.cli00, "%" + txtBuscar.Text + "%");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tHuella_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            link.cli00.date_modifyColumn.DefaultValue = DateTime.Now;
            try
            {
                bindingNavigatorAddNewItem.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fLimite.Value = DateTime.Now;
            nuevo = true;
            //tbEmpresa.Text = WindowsFormsApplication1.Properties.Settings.Default.Sucursal;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Talon frm = new Talon();
            frm.IdCliente = int.Parse(lCcli.Text.Trim());
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cli00TableAdapter.FillByCliente(link.cli00, int.Parse(lCcli.Text.Trim()));
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
        }

        private void tPagos_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagos00TableAdapter.FillByCli(link.pagos00, int.Parse(lCcli.Text));
        }

        private void lCcli_TextChanged(object sender, EventArgs e)
        {
            link.pagos00.Clear();
            link.registro00.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            registro00TableAdapter.FillByCli(link.registro00, int.Parse(lCcli.Text));
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            PideCliente frm = new PideCliente();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cli00TableAdapter.FillByCliente(link.cli00, frm.Ccli);
            }
        }
    }
}
