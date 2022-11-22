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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'link.gastos00' table. You can move, or remove it, as needed.
            this.gastos00TableAdapter.FillByPeriodo(this.link.gastos00,DateTime.Today,DateTime.Now);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gastos00BindingSource.EndEdit();
            gastos00TableAdapter.Update(link.gastos00);
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            dataGridView1.CurrentRow.Cells["fechaela"].Value = DateTime.Now;
        }

        private void gastos00BindingSource_PositionChanged(object sender, EventArgs e)
        {
        }
    }
}
