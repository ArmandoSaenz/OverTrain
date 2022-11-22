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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.cli00TableAdapter.FillByVencidos(link.cli00, DateTime.Now.Date);
            int countCliVigentes = (int)this.cli00TableAdapter.CountCliVigentes(DateTime.Now.Date).GetValueOrDefault(0);
            label18.Text = "Clientes Vigentes: " + countCliVigentes.ToString();
            label19.Text = "Clientes por vencidos el dia de hoy: " + link.cli00.Count.ToString();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            corte00TableAdapter.FillByDia(link.corte00, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            corte00TableAdapter.FillByFechaHora(link1.corte00, (DateTime)listBox1.SelectedValue);
            PreviewCorte frm = new PreviewCorte();
            ((ImpCorte)frm.crystalReportViewer1.ReportSource).SetDataSource(link1);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventas00TableAdapter.FillByTurno(link.ventas00, dateTimePicker3.Value.Date, dateTimePicker3.Value.Date.AddDays(1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagos00TableAdapter.FillByPeriodo(link.pagos00, dateTimePicker2.Value.Date, dateTimePicker2.Value.Date.AddDays(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreviewPagos frm = new PreviewPagos();
            ((imppagos)frm.crystalReportViewer1.ReportSource).SetDataSource(link);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PreviewVentas frm = new PreviewVentas();
            ((impVentas)frm.crystalReportViewer1.ReportSource).SetDataSource(link);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int posicion = corte00BindingSource.Position;
            if (posicion == 0)
            {
                corte00TableAdapter.FillByFechaHora(link1.corte00, (DateTime)listBox1.SelectedValue);
                pagos00TableAdapter.FillByPeriodo(link1.pagos00, ((DateTime)listBox1.SelectedValue).Date,(DateTime)listBox1.SelectedValue);
            }
            else
            {
                corte00TableAdapter.FillByFechaHora(link1.corte00, (DateTime)listBox1.SelectedValue);
                pagos00TableAdapter.FillByPeriodo(link1.pagos00, link.corte00[posicion-1].fechaela,link.corte00[posicion].fechaela);
            }
            corte00TableAdapter.FillByFechaHora(link1.corte00, (DateTime)listBox1.SelectedValue);
            PrevieCorteConcetrado frm = new PrevieCorteConcetrado();
            ((ImpCorteConcentrado)frm.crystalReportViewer1.ReportSource).SetDataSource(link1);
            frm.ShowDialog();
        }

        //private void fillByVencidosToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.cli00TableAdapter.FillByVencidos(this.link.cli00, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fechaToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void Reportes_Shown(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PreviewClientes frm = new PreviewClientes();
            ((ImpClientes)frm.crystalReportViewer1.ReportSource).SetDataSource(link);
            frm.ShowDialog();
        }
    }
}
