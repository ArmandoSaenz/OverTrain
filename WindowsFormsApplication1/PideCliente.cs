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
    public partial class PideCliente : Form
    {
        public int Ccli { get { return _cliente; } set { _cliente = value; } }
        int _cliente;
        public PideCliente()
        {
            InitializeComponent();
        }

        private void PideCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCli.Text.Trim(), out _cliente))
            {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                txtCli.Focus();
                txtCli.Clear();
            }
       }

    }
}
