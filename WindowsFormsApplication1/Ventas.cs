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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventas00BindingSource.CancelEdit();
        }

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            int can;
            decimal precio;
            if(int.TryParse(txtCan.Text,out can) && decimal.TryParse(lPrecio.Text,out precio))
            {
                lTotal.Text = (can * precio).ToString("#,###.##");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lFecha.Text = DateTime.Now.ToString();
            dateTimePicker1.Value = DateTime.Now;
            ventas00BindingSource.EndEdit();
            ventas00TableAdapter.Update(link.ventas00);
            if (MessageBox.Show("¿Deseas cargar mas información?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtCart.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                lnart.Text = dataGridView1.CurrentRow.Cells["articulo"].Value.ToString();
                lPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtCan_TextChanged(null, null);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            inventario00TableAdapter.FillByArticulo(link.inventario00, "%" + txtBuscar.Text + "%");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
