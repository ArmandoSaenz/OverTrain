namespace WindowsFormsApplication1.Utilities
{
    partial class FrmMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lMensaje
            // 
            this.lMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensaje.Location = new System.Drawing.Point(0, 0);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Padding = new System.Windows.Forms.Padding(15);
            this.lMensaje.Size = new System.Drawing.Size(317, 135);
            this.lMensaje.TabIndex = 0;
            this.lMensaje.Text = "label1";
            this.lMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 135);
            this.Controls.Add(this.lMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMonitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lMensaje;
    }
}