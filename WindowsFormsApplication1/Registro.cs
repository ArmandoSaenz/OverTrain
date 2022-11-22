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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                registro00TableAdapter.FillByFecha(link.registro00, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro00TableAdapter.FillByFecha(link.registro00, dateTimePicker2.Value.Date, dateTimePicker3.Value.Date.AddDays(1));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registro01TableAdapter.FillByDia(link.registro01, dateTimePicker4.Value.Date, dateTimePicker4.Value.Date.AddDays(1));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registro01TableAdapter.FillByDia(link.registro01, dateTimePicker5.Value.Date, dateTimePicker6.Value.Date.AddDays(1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PreviewAccesoPersonal frm = new PreviewAccesoPersonal();
            ((ImpAccesoPersonal)frm.crystalReportViewer1.ReportSource).SetDataSource(link);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreviewRegistroClientes frm = new PreviewRegistroClientes();
            ((impAcceso)frm.crystalReportViewer1.ReportSource).SetDataSource(link);
            frm.ShowDialog();
        }
    }
}
