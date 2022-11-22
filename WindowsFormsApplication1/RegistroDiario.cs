using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegistroDiario : Form
    {
        DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
        DPFP.Template template = new DPFP.Template();
        DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
        Info datos = new Info();
        Color oriColor;
        public RegistroDiario()
        {
            InitializeComponent();
            datos.DataBindings.Add(new Binding("fechaLimite",cli00BindingSource,"FLimite",true));
            datos.DataBindings.Add("fechaPago",cli00BindingSource,"fechapago");
            oriColor = lStatus.ForeColor;
        }

        private void RegistroDiario_Load(object sender, EventArgs e)
        {
        }
        private void verificationControl1_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            lStatus.ForeColor = new Color();
            lStatus.Text = "Buscando";
            cli00TableAdapter.ListaCliVigentes(link.cli00, DateTime.Today.AddMonths(-3));
            // Compare feature set with all stored templates.
            foreach (Link.cli00Row arg in link.cli00)
            {
                // Get template from storage.
                if (!arg.IshuellaNull())
                {
                    template.DeSerialize(arg.huella);
                    // Compare feature set with particular template.
                    ver.Verify(FeatureSet, template, ref res);
                    if (res.Verified)
                    {
                        cli00BindingSource.Position=cli00BindingSource.Find("idcli", arg.idcli);
                        Registro();
                        break;
                    }
                }
            }

            if (!res.Verified)
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                lStatus.Text = "Cliente no identificado";
                link.cli00.Clear();
            }
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
        }

        private void Registro()
        {
            if (dtpLimite.Value >= DateTime.Today)
            {
                lStatus.Text = "Vigente";
                registro00TableAdapter.NuevoAcceso(int.Parse(lCCli.Text), lNCli.Text, "Vigente", "Permitido");
                return;
            }
            if (dtpPago.Value > DateTime.Today)
            {
                lStatus.Text = "Pago Pendiente";
                registro00TableAdapter.NuevoAcceso(int.Parse(lCCli.Text), lNCli.Text, "Pago Pendiente", "Permitido");
                return;
            }
            if (dtpPago.Value <= DateTime.Today)
            {
                lStatus.ForeColor = Color.Red;
                AccionesCliente frm = new AccionesCliente();
                frm.idcli = int.Parse(lCCli.Text);
                lStatus.Text = "Membresía Vencida";
                Application.DoEvents();
                switch(frm.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        registro00TableAdapter.NuevoAcceso(int.Parse(lCCli.Text), lNCli.Text, "Vencida", "Permitido");
                    break;
                    case System.Windows.Forms.DialogResult.No:
                        registro00TableAdapter.NuevoAcceso(int.Parse(lCCli.Text), lNCli.Text, "Vencida", "No Permitido");
                        break;
                    case System.Windows.Forms.DialogResult.OK:
                        cli00TableAdapter.FillByCliente(link.cli00,int.Parse(lCCli.Text));
                        Registro();
                        break;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (cli00TableAdapter.FillByCliente(link.cli00, int.Parse(textBox1.Text.Trim())) == 1)
                {
                    Registro();
                }
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Talon frm = new Talon();
            frm.IdCliente = int.Parse(lCCli.Text);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificationControl1.Active = false;
            RegistroPersonal frm = new RegistroPersonal();
            frm.ShowDialog();
            verificationControl1.Active = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verificationControl1.Active = false;
            Huella frm = new Huella();
            frm.cliente = link.cli00[cli00BindingSource.Position];
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cli00TableAdapter.Update(link.cli00);
            }
            try
            {
                cli00RemoteAdapter.UpdateFingerPrint(link.cli00[0].huella, DateTime.Now, link.cli00[0].id);
            }
            catch (Exception err)
            {
                //
            }
            verificationControl1.Active = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Talon frm = new Talon();
            frm.IdCliente = 0;
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ventas frm = new Ventas();
            frm.ShowDialog();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

    public partial class Info : Control
    {
        private DateTime _fechaLimite;
        private DateTime _fechaPago;
        private int _idCli;
        private string _nCli;
        public DateTime fechaLimite{ get{return _fechaLimite;} set{_fechaLimite = value;}}
        public DateTime fechaPago { get { return _fechaPago; } set { _fechaPago = value; } }
        public int idCli { get { return _idCli; } set { _idCli = value; } }
        public string nCli { get { return _nCli; } set { _nCli = value; } }
        public Info() { }
    }
}

