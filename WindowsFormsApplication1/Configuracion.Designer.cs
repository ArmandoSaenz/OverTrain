namespace WindowsFormsApplication1
{
    partial class Configuracion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.conf00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link = new WindowsFormsApplication1.Link();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.conf00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.conf00TableAdapter();
            this.rtbDatosFiscales = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lMachineName = new System.Windows.Forms.Label();
            this.lAppFolder = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPrinters = new System.Windows.Forms.ComboBox();
            this.rbTicket58mm = new System.Windows.Forms.RadioButton();
            this.tbTicket80mm = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.conf00BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(86, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 50);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(12, 215);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 50);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Base de datos:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.LogOff;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(690, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 65);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cerrar Sesión";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conf00BindingSource, "pass", true));
            this.txtPass.Location = new System.Drawing.Point(98, 15);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 20);
            this.txtPass.TabIndex = 33;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // conf00BindingSource
            // 
            this.conf00BindingSource.DataMember = "conf00";
            this.conf00BindingSource.DataSource = this.link;
            // 
            // link
            // 
            this.link.DataSetName = "Link";
            this.link.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.Location = new System.Drawing.Point(98, 52);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(156, 20);
            this.txtServer.TabIndex = 34;
            // 
            // txtDb
            // 
            this.txtDb.BackColor = System.Drawing.Color.White;
            this.txtDb.Location = new System.Drawing.Point(98, 89);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(156, 20);
            this.txtDb.TabIndex = 35;
            // 
            // conf00TableAdapter
            // 
            this.conf00TableAdapter.ClearBeforeFill = true;
            // 
            // rtbDatosFiscales
            // 
            this.rtbDatosFiscales.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "encabezado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtbDatosFiscales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDatosFiscales.Location = new System.Drawing.Point(3, 16);
            this.rtbDatosFiscales.Name = "rtbDatosFiscales";
            this.rtbDatosFiscales.Size = new System.Drawing.Size(246, 116);
            this.rtbDatosFiscales.TabIndex = 37;
            this.rtbDatosFiscales.Text = global::WindowsFormsApplication1.Properties.Settings.Default.encabezado;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDatosFiscales);
            this.groupBox1.Location = new System.Drawing.Point(291, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 135);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Fiscales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDb);
            this.groupBox2.Controls.Add(this.txtServer);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 129);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de la Base de datos";
            // 
            // lMachineName
            // 
            this.lMachineName.AutoSize = true;
            this.lMachineName.Location = new System.Drawing.Point(9, 157);
            this.lMachineName.Name = "lMachineName";
            this.lMachineName.Size = new System.Drawing.Size(90, 13);
            this.lMachineName.TabIndex = 31;
            this.lMachineName.Text = "Nombre de la PC:";
            // 
            // lAppFolder
            // 
            this.lAppFolder.AutoSize = true;
            this.lAppFolder.Location = new System.Drawing.Point(9, 182);
            this.lAppFolder.Name = "lAppFolder";
            this.lAppFolder.Size = new System.Drawing.Size(50, 13);
            this.lAppFolder.TabIndex = 40;
            this.lAppFolder.TabStop = true;
            this.lAppFolder.Text = "Carpeta: ";
            this.lAppFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lAppFolder_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTicket80mm);
            this.groupBox3.Controls.Add(this.rbTicket58mm);
            this.groupBox3.Controls.Add(this.cbPrinters);
            this.groupBox3.Location = new System.Drawing.Point(567, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 132);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impresion de Tickets";
            // 
            // cbPrinters
            // 
            this.cbPrinters.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "TicketPrinter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbPrinters.FormattingEnabled = true;
            this.cbPrinters.Location = new System.Drawing.Point(6, 16);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(179, 21);
            this.cbPrinters.TabIndex = 0;
            this.cbPrinters.Text = global::WindowsFormsApplication1.Properties.Settings.Default.TicketPrinter;
            // 
            // rbTicket58mm
            // 
            this.rbTicket58mm.AutoSize = true;
            this.rbTicket58mm.Checked = global::WindowsFormsApplication1.Properties.Settings.Default.Ticket58;
            this.rbTicket58mm.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApplication1.Properties.Settings.Default, "Ticket58", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbTicket58mm.Location = new System.Drawing.Point(6, 43);
            this.rbTicket58mm.Name = "rbTicket58mm";
            this.rbTicket58mm.Size = new System.Drawing.Size(56, 17);
            this.rbTicket58mm.TabIndex = 1;
            this.rbTicket58mm.TabStop = true;
            this.rbTicket58mm.Text = "58 mm";
            this.rbTicket58mm.UseVisualStyleBackColor = true;
            // 
            // tbTicket80mm
            // 
            this.tbTicket80mm.AutoSize = true;
            this.tbTicket80mm.Checked = global::WindowsFormsApplication1.Properties.Settings.Default.Ticket80;
            this.tbTicket80mm.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApplication1.Properties.Settings.Default, "Ticket80", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTicket80mm.Location = new System.Drawing.Point(6, 66);
            this.tbTicket80mm.Name = "tbTicket80mm";
            this.tbTicket80mm.Size = new System.Drawing.Size(56, 17);
            this.tbTicket80mm.TabIndex = 2;
            this.tbTicket80mm.Text = "80 mm";
            this.tbTicket80mm.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 277);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lAppFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lMachineName);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conf00BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDb;
        private Link link;
        private System.Windows.Forms.BindingSource conf00BindingSource;
        private LinkTableAdapters.conf00TableAdapter conf00TableAdapter;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RichTextBox rtbDatosFiscales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lMachineName;
        private System.Windows.Forms.LinkLabel lAppFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPrinters;
        private System.Windows.Forms.RadioButton tbTicket80mm;
        private System.Windows.Forms.RadioButton rbTicket58mm;
    }
}