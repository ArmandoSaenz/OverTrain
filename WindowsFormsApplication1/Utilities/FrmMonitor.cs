using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Utilities
{
    public partial class FrmMonitor : Form
    {
        static private FrmMonitor Instance = null;
        static public FrmMonitor GetInstance()
        {
            if (Instance == null)
                Instance = new FrmMonitor();
            return Instance;
        }
        static public void Show(string msg)
        {
            FrmMonitor frmMonitor = FrmMonitor.GetInstance();
            if (frmMonitor.DialogResult != DialogResult.None)
            {
                frmMonitor.Show();
            }
            frmMonitor.lMensaje.Text = msg;
        }
        static public void Close()
        {
            FrmMonitor frmMonitor = FrmMonitor.GetInstance();
            frmMonitor.DialogResult = DialogResult.OK;
        }
        public FrmMonitor()
        {
            InitializeComponent();
        }
    }
}
