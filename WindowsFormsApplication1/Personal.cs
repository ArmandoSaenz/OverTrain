using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Personal : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        byte[] huella;
        Datos datos = new Datos();

        public Personal()
        {
            InitializeComponent();
            datos.DataBindings.Add(new Binding("Huella",personal00BindingSource,"huella",true));
            BuscarDispositivos();
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
            {
                comboBox1.Items.Add(Dispositivos[i].Name.ToString());
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            Foto.Image = Imagen;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Camara")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[comboBox1.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    comboBox1.Enabled = false;
                    btnConectar.Text = "Detener";
                }
                else
                {
                    Estado.Text = "Error: No se encuentra dispositivo.";
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = " Dispositivo detenido";
                    btnConectar.Text = "Camara";
                    comboBox1.Enabled = true;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Foto.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'link.personal00' table. You can move, or remove it, as needed.
            this.personal00TableAdapter.Fill(this.link.personal00);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personal00BindingSource.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal00BindingSource.EndEdit();
            personal00TableAdapter.Update(link.personal00);
            if (MessageBox.Show("¿Deseas cargar mas información?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            Template.Serialize(ref huella);
            //dataGridView1.Rows[personal00BindingSource.Position].Cells["cHuella"].Value = huella;
            dataGridView1.CurrentRow.Cells["cHuella"].Value = huella;
        }
    }
}