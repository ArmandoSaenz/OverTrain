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
    public partial class AccionesCliente : Form
    {
        public AccionesCliente()
        {
            InitializeComponent();
        }

        private int _idcli;
        public int idcli { get { return _idcli; } set { _idcli = value; } }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Talon frm = new Talon();
            frm.IdCliente = _idcli;
            this.DialogResult = frm.ShowDialog();
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void entradaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}
