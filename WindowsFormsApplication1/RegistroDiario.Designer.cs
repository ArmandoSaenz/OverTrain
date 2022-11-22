namespace WindowsFormsApplication1
{
    partial class RegistroDiario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cli00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link = new WindowsFormsApplication1.Link();
            this.cli00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.cli00TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lCCli = new System.Windows.Forms.Label();
            this.lNCli = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.lStatus = new System.Windows.Forms.Label();
            this.registro00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registro00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.registro00TableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cli00RemoteAdapter = new WindowsFormsApplication1.Models.LinkRemoteTableAdapters.cli00TableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.linkRemote = new WindowsFormsApplication1.Models.LinkRemote();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli00BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro00BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkRemote)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.silueta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cli00BindingSource, "foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cli00BindingSource
            // 
            this.cli00BindingSource.DataMember = "cli00";
            this.cli00BindingSource.DataSource = this.link;
            // 
            // link
            // 
            this.link.DataSetName = "Link";
            this.link.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli00TableAdapter
            // 
            this.cli00TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha final membresía:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ultima fecha de pago:";
            // 
            // lCCli
            // 
            this.lCCli.AutoSize = true;
            this.lCCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cli00BindingSource, "idcli", true));
            this.lCCli.Location = new System.Drawing.Point(423, 69);
            this.lCCli.Name = "lCCli";
            this.lCCli.Size = new System.Drawing.Size(85, 13);
            this.lCCli.TabIndex = 7;
            this.lCCli.Text = "Clave del cliente";
            this.lCCli.TextChanged += new System.EventHandler(this.label7_TextChanged);
            // 
            // lNCli
            // 
            this.lNCli.AutoSize = true;
            this.lNCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cli00BindingSource, "ncli", true));
            this.lNCli.Location = new System.Drawing.Point(423, 100);
            this.lNCli.Name = "lNCli";
            this.lNCli.Size = new System.Drawing.Size(95, 13);
            this.lNCli.TabIndex = 8;
            this.lNCli.Text = "Nombre del cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cli00BindingSource, "empresa", true));
            this.label9.Location = new System.Drawing.Point(423, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Empresa";
            // 
            // btnPago
            // 
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.Image = global::WindowsFormsApplication1.Properties.Resources.dolar;
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPago.Location = new System.Drawing.Point(615, 205);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(68, 50);
            this.btnPago.TabIndex = 24;
            this.btnPago.Text = "&Pago";
            this.btnPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(309, 264);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(48, 47);
            this.verificationControl1.TabIndex = 25;
            this.verificationControl1.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.verificationControl1_OnComplete);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(303, 330);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(229, 25);
            this.lStatus.TabIndex = 26;
            this.lStatus.Text = "Status de la Busqueda";
            // 
            // registro00BindingSource
            // 
            this.registro00BindingSource.DataMember = "registro00";
            this.registro00BindingSource.DataSource = this.link;
            // 
            // registro00TableAdapter
            // 
            this.registro00TableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ingresar clave del cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dtpLimite
            // 
            this.dtpLimite.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cli00BindingSource, "FLimite", true));
            this.dtpLimite.Location = new System.Drawing.Point(426, 151);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(200, 20);
            this.dtpLimite.TabIndex = 29;
            // 
            // dtpPago
            // 
            this.dtpPago.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cli00BindingSource, "fechapago", true));
            this.dtpPago.Location = new System.Drawing.Point(426, 179);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(200, 20);
            this.dtpPago.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Buddy_Blue1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(615, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "P&ersonal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(426, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 97);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "areas de Acceso";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cli00BindingSource, "area3", true));
            this.checkBox3.Location = new System.Drawing.Point(22, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Aerobico";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cli00BindingSource, "area2", true));
            this.checkBox2.Location = new System.Drawing.Point(22, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Spining";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cli00BindingSource, "area1", true));
            this.checkBox1.Location = new System.Drawing.Point(22, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pesas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.Buddy_Green1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(615, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 68);
            this.button2.TabIndex = 33;
            this.button2.Text = "&Registrar Huella";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.Buddy_Green1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(624, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 57);
            this.button3.TabIndex = 34;
            this.button3.Text = "&Visita";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(615, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 68);
            this.button4.TabIndex = 35;
            this.button4.Text = "Cliente &Nuevo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::WindowsFormsApplication1.Properties.Resources.Hot_Dog_Car;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(615, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 53);
            this.button5.TabIndex = 36;
            this.button5.Text = "Ven&ta";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cli00RemoteAdapter
            // 
            this.cli00RemoteAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Buscar por ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(440, 36);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(135, 20);
            this.tbID.TabIndex = 38;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // linkRemote
            // 
            this.linkRemote.DataSetName = "LinkRemote";
            this.linkRemote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegistroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 518);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpPago);
            this.Controls.Add(this.dtpLimite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.verificationControl1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lNCli);
            this.Controls.Add(this.lCCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegistroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.RegistroDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli00BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro00BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkRemote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Link link;
        private System.Windows.Forms.BindingSource cli00BindingSource;
        private LinkTableAdapters.cli00TableAdapter cli00TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lCCli;
        private System.Windows.Forms.Label lNCli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPago;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.BindingSource registro00BindingSource;
        private LinkTableAdapters.registro00TableAdapter registro00TableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Models.LinkRemoteTableAdapters.cli00TableAdapter cli00RemoteAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID;
        private Models.LinkRemote linkRemote;
    }
}