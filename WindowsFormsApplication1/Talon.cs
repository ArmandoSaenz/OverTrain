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
    public partial class Talon : Form
    {

        DateTime fechaini,fechafin,fechapag;
        int ccli;
        public int IdCliente 
        {
            get
            {
                return ccli;
            }

            set
            {
                ccli = value;
            }
        }
        public Talon()
        {
            InitializeComponent();
            bindingNavigatorAddNewItem.PerformClick();
            label11.Text = DateTime.Now.ToString();
        }

        private void Talon_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'link.precio00' table. You can move, or remove it, as needed.
            this.precio00TableAdapter.Fill(this.link.precio00);
            if (IdCliente != 0)
            {
                comboBox2.SelectedIndex = 1;
            }
            else
            {
                label14.Text = comboBox2.SelectedValue.ToString();
            }
            buscarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagos00BindingSource.EndEdit();
            pagos00TableAdapter.Update(link.pagos00);
            link.pagos00[0].id = (int)pagos00TableAdapter.Adapter.InsertCommand.LastInsertedId;
            Utilities.FrmMonitor.Show("Actualizando la membresia local");
            cli00TableAdapter.FechaLimite(fechafin, IdCliente);
            cli00TableAdapter.FechaPago(fechapag, IdCliente);
            if (link.cli00.Count > 0 && link.cli00[0].id > 0)
            {
                Utilities.FrmMonitor.Show("Actualizando la membresia en la nube");
                Models.LinkRemoteTableAdapters.cli00TableAdapter cli00RemoteAdapter = new Models.LinkRemoteTableAdapters.cli00TableAdapter();
                try
                {
                    cli00RemoteAdapter.UpdateMembership(fechafin, fechapag, DateTime.Now, link.cli00[0].id);
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se pudo subir la información de la membresía" + System.Environment.NewLine + err.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Utilities.FrmMonitor.Close();
            cli00TableAdapter.UpdateDateModify(DateTime.Now, IdCliente);
            CrystalDecisions.CrystalReports.Engine.ReportClass Ticket = null;
            do
            {

                if (WindowsFormsApplication1.Properties.Settings.Default.Ticket58)
                {
                    Ticket = new Ticket58mm();
                }
                else if (WindowsFormsApplication1.Properties.Settings.Default.Ticket80)
                {
                    Ticket = new Ticket80mm();
                }
                Ticket.SetDataSource(link);
                Ticket.SetParameterValue(0, WindowsFormsApplication1.Properties.Settings.Default.encabezado);
                Ticket.SetParameterValue(1, link.cli00.Count > 0 ? link.cli00[0].id : 0);
                Ticket.PrintOptions.PrinterName = WindowsFormsApplication1.Properties.Settings.Default.TicketPrinter;
                Ticket.PrintToPrinter(1, false, 0, 0);
            }
            while (MessageBox.Show("¿Imprimir ticket?", "", MessageBoxButtons.YesNo) == DialogResult.Yes);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void precio00BindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox2.SelectedValue.ToString() == "")
            {
                return;
            }
            else
            {
                label14.Text = ((Decimal)comboBox2.SelectedValue).ToString("#,###.##");
            }

            if (!comboBox2.Enabled)
            {
                return;
            }
            if (radioButton1.Checked)
            {
                fechafin = fechaini.AddDays(6);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = label13.Text;
            }
            if (radioButton2.Checked)
            {
                fechafin = fechaini.AddDays(13);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = fechapag.ToShortDateString();
            }
            if (radioButton3.Checked)
            {
                fechafin = fechaini.AddMonths(1).AddDays(-1);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = fechapag.ToShortDateString();
            }
            if (radioButton4.Checked)
            {
                fechafin = fechaini.AddMonths(3).AddDays(-1);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = fechapag.ToShortDateString();
            }
            if (radioButton5.Checked)
            {
                fechafin = fechaini.AddMonths(6).AddDays(-1);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = fechapag.ToShortDateString();
            }
            if (radioButton6.Checked)
            {
                fechafin = fechaini.AddYears(1).AddDays(-1);
                fechapag = fechafin.AddDays(1);
                label13.Text = fechafin.ToShortDateString();
                label17.Text = fechapag.ToShortDateString();
            }
        }

        public void buscarCliente()
        {
            if (ccli == 0)
            {
                label10.Text = "Visita";
                label11.Text = DateTime.Now.ToShortDateString();
                label12.Text = DateTime.Today.ToShortDateString();
                label13.Text = DateTime.Today.ToShortDateString();
                label17.Text = DateTime.Today.ToShortDateString();
                label15.Text = "";
                comboBox2.Enabled = false;
                comboBox2.Text = "";
                comboBox2.Text = "Visita";
                return;
            }
            comboBox2.Enabled = true;
            label11.Text = DateTime.Now.ToString();
            cli00TableAdapter.FillByCliente(link.cli00, ccli);
            label9.Text= link.cli00[0].idcli.ToString();
            label10.Text = link.cli00[0].ncli;
            if (link.cli00[0].IsempresaNull())
            {
                label15.Text = "";
            }
            else
            {
                label15.Text = link.cli00[0].empresa;
            }
            if (link.cli00[0].IsFLimiteNull())
            {
                fechaini = DateTime.Today;
            }
            else
            {
                if (link.cli00[0].FLimite > DateTime.Now)
                {
                    fechaini = link.cli00[0].FLimite.AddDays(1);
                }
                else
                {
                    fechaini = DateTime.Today;
                }
            }
            label12.Text = fechaini.ToShortDateString();
            if (link.cli00[0].ncli.Trim() == "VISITA VISITA VISITA")
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = 0;
                label12.Text = DateTime.Today.ToShortDateString();
                label13.Text = DateTime.Today.ToShortDateString();
                label17.Text = DateTime.Today.ToShortDateString();
                label15.Text = "";
            }
            Application.DoEvents();
            precio00BindingSource_BindingComplete(null, null);
        }

    }
}
