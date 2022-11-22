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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }
        List<int> clientes1;
        List<int> clientes2;

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'link.pagos00' table. You can move, or remove it, as needed.
            this.pagos00TableAdapter.FillByPeriodo(this.link.pagos00,DateTime.Today,DateTime.Today.AddDays(1));
            link1 = (Link)link.Copy();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime? tmp, tmp2;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            pagos00BindingSource.EndEdit();
            pagos00TableAdapter.Update(link.pagos00);
            DateTime FechaPago, FechaLimite;
            Models.LinkRemoteTableAdapters.cli00TableAdapter cli00RemoteAdapter = new Models.LinkRemoteTableAdapters.cli00TableAdapter();
            foreach (Link.pagos00Row arg in link1.pagos00)
            {
                if(!link.pagos00.Contains(arg))
                {
                    tmp = pagos00TableAdapter.Fechafinal(arg.idcli);
                    tmp2 = pagos00TableAdapter.FechaPago(arg.idcli);
                    FechaLimite = tmp.HasValue ? tmp.Value : DateTime.Today.AddDays(-1);
                    FechaPago = tmp2.HasValue ? tmp2.Value : DateTime.Today;
                    cli00TableAdapter.FechaLimite(FechaLimite,arg.idcli);
                    cli00TableAdapter.FechaPago(FechaPago, arg.idcli);
                    try
                    {
                        if (cli00TableAdapter.FillByCliente(link.cli00, arg.idcli) > 0)
                        {
                            if (link.cli00[0].id > 0)
                            {
                                cli00RemoteAdapter.UpdateMembership(FechaLimite, FechaPago, DateTime.Now, link.cli00[0].id);
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("No se pudo subir la información de la membresía" + System.Environment.NewLine + err.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (MessageBox.Show("Deseas cargar mas información", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pagos00BindingSource.CancelEdit();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }
    }
}
