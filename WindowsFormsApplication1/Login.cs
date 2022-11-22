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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (VarPub.admin)
            {
                Configuracion frm = new Configuracion();
                frm.ShowDialog();
                this.Close();
            }
            // TODO: This line of code loads data into the 'link1.conf00' table. You can move, or remove it, as needed.
            this.conf00TableAdapter.Fill(this.link1.conf00);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == link1.conf00[0].pass)
            {
                VarPub.admin = true;
                Configuracion frm = new Configuracion();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                VarPub.admin = false;
                MessageBox.Show("Contraseña incorreta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
