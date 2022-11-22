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
    public partial class Corte : Form
    {
        decimal cajaant, total, retiro, totalini,totalcaja,efectivo;
        public Corte()
        {
            InitializeComponent();
        }
        int num;
        decimal? pagos, ventas, gastos,totalefe, totaltar;
        private void Corte_Load(object sender, EventArgs e)
        {
            DateTime turno;
            DateTime hora = DateTime.Now; MostrarInfo frm = new MostrarInfo();
            frm.label1.Text = "Indentificando Corte";
            frm.Show();
            Application.DoEvents();
            num = corte00TableAdapter.FillByFecha(link.corte00, DateTime.Today, DateTime.Today.AddDays(1));
            switch (num)
            {
                case 0:
                    turno = DateTime.Today;
                    bindingNavigatorAddNewItem.PerformClick();
                    lFecha.Text = DateTime.Now.ToString();
                    pagos = (decimal?)pagos00TableAdapter.PagosDia(turno, hora);
                    totalefe = pagos00TableAdapter.EfectivoTurno(turno, hora);
                    totaltar = pagos00TableAdapter.TarjetaTurno(turno, hora);
                    ventas = (decimal?)ventas00TableAdapter.VentasDia(turno, hora);
                    gastos = (decimal?)gastos00TableAdapter.GastosDia(turno, hora);
                    lMontoPagos.Text = pagos.GetValueOrDefault(0.00M).ToString("C");
                    lEfectivo.Text = totalefe.GetValueOrDefault(0.00M).ToString("C");
                    lTarjeta.Text = totaltar.GetValueOrDefault(0.00M).ToString("C");
                    lMontoVentas.Text = ventas.GetValueOrDefault(0.00M).ToString("C");
                    lGastos.Text = gastos.GetValueOrDefault(0.00M).ToString("C");
                    total = pagos.GetValueOrDefault(0.00M)+ventas.GetValueOrDefault(0.00M) -gastos.GetValueOrDefault(0.00M);
                    totalcaja = totalefe.GetValueOrDefault(0.00M) + ventas.GetValueOrDefault(0.00M) - gastos.GetValueOrDefault(0.00M);
                    efectivo = totalcaja;
                    ltotalefe.Text = totalcaja.ToString("C");
                    lTotal.Text = total.ToString("C");
                    txtRetirado.Text = "0.00";
                    lCaja.Text = ltotalefe.Text;
                    textBox1.Focus();
                    break;
                default:
                    turno = link.corte00[0].fechaela;
                    cajaant = link.corte00[0].caja;
                    bindingNavigatorAddNewItem.PerformClick();
                    lFecha.Text = DateTime.Now.ToString();
                    textBox1.Text = cajaant.ToString("C");
                    textBox1.Enabled = false;
                    pagos = (decimal?)pagos00TableAdapter.PagosDia(turno, DateTime.Now);
                    totalefe = pagos00TableAdapter.EfectivoTurno(turno, hora);
                    totaltar = pagos00TableAdapter.TarjetaTurno(turno, hora);
                    ventas = (decimal?)ventas00TableAdapter.VentasDia(turno, DateTime.Now);
                    gastos = (decimal?)gastos00TableAdapter.GastosDia(turno, DateTime.Now);
                    lMontoPagos.Text = pagos.GetValueOrDefault(0.00M).ToString("C");
                    lMontoVentas.Text = ventas.GetValueOrDefault(0.00M).ToString("C");
                    lGastos.Text = gastos.GetValueOrDefault(0.00M).ToString("C");
                    lEfectivo.Text = totalefe.GetValueOrDefault(0.00M).ToString("C");
                    lTarjeta.Text = totaltar.GetValueOrDefault(0.00M).ToString("C");
                    total = pagos.GetValueOrDefault(0.00M)+ventas.GetValueOrDefault(0.00M) -gastos.GetValueOrDefault(0.00M)+cajaant;
                    totalcaja = totalefe.GetValueOrDefault(0.00M) + ventas.GetValueOrDefault(0.00M) - gastos.GetValueOrDefault(0.00M) + cajaant;
                    efectivo = totalcaja;
                    ltotalefe.Text = totalcaja.ToString("C");
                    lTotal.Text = total.ToString("C");
                    txtRetirado.Text = "0.00";
                    txtRetirado.Focus();
                    lCaja.Text = ltotalefe.Text;
                    break;
            }
            frm.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cajaant = decimal.Parse(textBox1.Text);
                totalini = total + cajaant;
                efectivo = totalcaja + cajaant;
                lTotal.Text = totalini.ToString("C");
                ltotalefe.Text = efectivo.ToString("C");
                txtRetirado.Focus();
            }
        }

        private void txtRetirado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                retiro = decimal.Parse(txtRetirado.Text);
                lCaja.Text = (efectivo - retiro).ToString("C");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            corte00BindingSource.EndEdit();
            corte00TableAdapter.Update(link.corte00);
            MessageBox.Show("Corte Guardado");
            this.Close();
        }
    }
}
