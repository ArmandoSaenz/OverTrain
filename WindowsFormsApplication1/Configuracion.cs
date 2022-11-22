using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using System.Net;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Configuracion : Form
    {
        private string GetShortPath(string path)
        {
            string shortPath;
            shortPath = path.Length <= 50 ? path : Path.GetPathRoot(path) + @"...\" +Path.GetFileName(path);
            return shortPath;
        }
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'link.conf00' table. You can move, or remove it, as needed.
            if (txtPass.Enabled)
            {
                this.conf00TableAdapter.Fill(this.link.conf00);
            }
            string[] datos = Settings.Default.conexion.Split(';');
            string[] server = datos[0].Split('=');
            string[] db = datos[3].Split('=');
            txtServer.Text = server[1];
            txtDb.Text = db[1];
            lMachineName.Text = "Nombre de la PC: " + System.Environment.MachineName;
            lAppFolder.Text = "Carpeta: " + GetShortPath(System.Environment.CurrentDirectory);
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinters.Items.Add(printer);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Settings.Default.conexion = "server="+txtServer.Text.Trim()+";User Id=root;Persist Security Info=True;database="+txtDb.Text.Trim();
            Settings.Default.Save();
            if (txtPass.Enabled)
            {
                conf00BindingSource.EndEdit();
                conf00TableAdapter.Update(link.conf00);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VarPub.admin = false;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lAppFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.CurrentDirectory);
        }
    }
}
