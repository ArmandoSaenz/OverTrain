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
    public partial class Precios : Form
    {
        public Precios()
        {
            InitializeComponent();
        }

        private void Precios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'link.precio00' table. You can move, or remove it, as needed.
            this.precio00TableAdapter.Fill(this.link.precio00);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            precio00BindingSource.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            precio00BindingSource.EndEdit();
            precio00TableAdapter.Update(link.precio00);
            if (MessageBox.Show("Deseas cargar mas información","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch(textBox1.Text)
            {
                case "Visita":
                case "Semana":
                case "Quincena":
                case "Mes":
                case "Año":
                case "Trimestre":
                case "Semestre":
                    textBox1.Enabled = false;
                    break;
                default:
                    textBox1.Enabled = true;
                    break;
            }
        }
    }
}
