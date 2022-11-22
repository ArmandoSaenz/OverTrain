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
    public partial class RegistroPersonal : Form
    {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Template template = new DPFP.Template();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void RegistroPersonal_Load(object sender, EventArgs e)
        {
        }

        private void RegistroEmpleado()
        {
            bindingNavigatorAddNewItem.PerformClick();
            label4.Tag = label4.Text;
            label5.Tag = label5.Text;
            label6.Text = DateTime.Now.ToString();
            registro01BindingSource.EndEdit();
            registro01TableAdapter.Update(link.registro01);
            Application.DoEvents();
            System.Threading.Thread.Sleep(3000);
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                personal00TableAdapter.FillById(link.personal00, int.Parse(textBox1.Text.Trim()));
                if(link.personal00.Count > 0)
                {
                    RegistroEmpleado();
                }
            }
        }

        private void verificationControl1_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            personal00TableAdapter.Fill(link.personal00);
            // Compare feature set with all stored templates.
            foreach (Link.personal00Row arg in link.personal00)
            {
                // Get template from storage.
                if (!arg.IshuellaNull())
                {
                    template.DeSerialize(arg.huella);
                    // Compare feature set with particular template.
                    ver.Verify(FeatureSet, template, ref res);
                    if (res.Verified)
                    {
                        personal00BindingSource.Position = personal00BindingSource.Find("id", arg.id);
                        RegistroEmpleado();
                        break;
                    }
                }
            }
            if (res.Verified==false)
            {
                MessageBox.Show("Empleado no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
