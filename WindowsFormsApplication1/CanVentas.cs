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
    public partial class CanVentas : Form
    {
        public CanVentas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventas00BindingSource.CancelEdit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ventas00BindingSource.EndEdit();
            ventas00TableAdapter.Update(link.ventas00);
        }

        private void CanVentas_Load(object sender, EventArgs e)
        {
            ventas00TableAdapter.FillByTurno(link.ventas00, DateTime.Today, DateTime.Today.AddDays(1));
        }
    }
}
