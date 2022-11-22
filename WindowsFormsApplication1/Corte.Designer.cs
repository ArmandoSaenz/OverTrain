namespace WindowsFormsApplication1
{
    partial class Corte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetirado = new System.Windows.Forms.TextBox();
            this.corte00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link = new WindowsFormsApplication1.Link();
            this.lFecha = new System.Windows.Forms.Label();
            this.lMontoPagos = new System.Windows.Forms.Label();
            this.lMontoVentas = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lCaja = new System.Windows.Forms.Label();
            this.lGastos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pagos00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.pagos00TableAdapter();
            this.pagos00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventas00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corte00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.corte00TableAdapter();
            this.ventas00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.ventas00TableAdapter();
            this.gastos00BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastos00TableAdapter = new WindowsFormsApplication1.LinkTableAdapters.gastos00TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lEfectivo = new System.Windows.Forms.Label();
            this.lTarjeta = new System.Windows.Forms.Label();
            this.ltotalefe = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corte00BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagos00BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas00BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos00BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto de pagos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto de ventas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Retirado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Caja:";
            // 
            // txtRetirado
            // 
            this.txtRetirado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mretiro", true));
            this.txtRetirado.Location = new System.Drawing.Point(106, 181);
            this.txtRetirado.Name = "txtRetirado";
            this.txtRetirado.Size = new System.Drawing.Size(142, 20);
            this.txtRetirado.TabIndex = 1;
            this.txtRetirado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetirado_KeyPress);
            // 
            // corte00BindingSource
            // 
            this.corte00BindingSource.DataMember = "corte00";
            this.corte00BindingSource.DataSource = this.link;
            // 
            // link
            // 
            this.link.DataSetName = "Link";
            this.link.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "fechaela", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "g"));
            this.lFecha.Location = new System.Drawing.Point(106, 8);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(111, 13);
            this.lFecha.TabIndex = 12;
            this.lFecha.Text = "Fecha y hora de corte";
            // 
            // lMontoPagos
            // 
            this.lMontoPagos.AutoSize = true;
            this.lMontoPagos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mtalon", true));
            this.lMontoPagos.Location = new System.Drawing.Point(106, 66);
            this.lMontoPagos.Name = "lMontoPagos";
            this.lMontoPagos.Size = new System.Drawing.Size(37, 13);
            this.lMontoPagos.TabIndex = 13;
            this.lMontoPagos.Text = "Pagos";
            // 
            // lMontoVentas
            // 
            this.lMontoVentas.AutoSize = true;
            this.lMontoVentas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mventas", true));
            this.lMontoVentas.Location = new System.Drawing.Point(106, 95);
            this.lMontoVentas.Name = "lMontoVentas";
            this.lMontoVentas.Size = new System.Drawing.Size(40, 13);
            this.lMontoVentas.TabIndex = 14;
            this.lMontoVentas.Text = "Ventas";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mtotal", true));
            this.lTotal.Location = new System.Drawing.Point(106, 150);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(31, 13);
            this.lTotal.TabIndex = 15;
            this.lTotal.Text = "Total";
            // 
            // lCaja
            // 
            this.lCaja.AutoSize = true;
            this.lCaja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "caja", true));
            this.lCaja.Location = new System.Drawing.Point(106, 213);
            this.lCaja.Name = "lCaja";
            this.lCaja.Size = new System.Drawing.Size(28, 13);
            this.lCaja.TabIndex = 16;
            this.lCaja.Text = "Caja";
            // 
            // lGastos
            // 
            this.lGastos.AutoSize = true;
            this.lGastos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mgastos", true));
            this.lGastos.Location = new System.Drawing.Point(106, 122);
            this.lGastos.Name = "lGastos";
            this.lGastos.Size = new System.Drawing.Size(40, 13);
            this.lGastos.TabIndex = 18;
            this.lGastos.Text = "Gastos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Monto de gastos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::WindowsFormsApplication1.Properties.Resources.Close;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(244, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::WindowsFormsApplication1.Properties.Resources.Symbol_Check1;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(0, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 50);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.corte00BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(271, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(53, 294);
            this.bindingNavigator1.TabIndex = 30;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 14);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "minicio", true));
            this.textBox1.Location = new System.Drawing.Point(109, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pagos00TableAdapter
            // 
            this.pagos00TableAdapter.ClearBeforeFill = true;
            // 
            // pagos00BindingSource
            // 
            this.pagos00BindingSource.DataMember = "pagos00";
            this.pagos00BindingSource.DataSource = this.link;
            // 
            // ventas00BindingSource
            // 
            this.ventas00BindingSource.DataMember = "ventas00";
            this.ventas00BindingSource.DataSource = this.link;
            // 
            // corte00TableAdapter
            // 
            this.corte00TableAdapter.ClearBeforeFill = true;
            // 
            // ventas00TableAdapter
            // 
            this.ventas00TableAdapter.ClearBeforeFill = true;
            // 
            // gastos00BindingSource
            // 
            this.gastos00BindingSource.DataMember = "gastos00";
            this.gastos00BindingSource.DataSource = this.link;
            // 
            // gastos00TableAdapter
            // 
            this.gastos00TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Pagos Efectivo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Pagos Tarjeta:";
            // 
            // lEfectivo
            // 
            this.lEfectivo.AutoSize = true;
            this.lEfectivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mefectivo", true));
            this.lEfectivo.Location = new System.Drawing.Point(286, 66);
            this.lEfectivo.Name = "lEfectivo";
            this.lEfectivo.Size = new System.Drawing.Size(46, 13);
            this.lEfectivo.TabIndex = 33;
            this.lEfectivo.Text = "Efectivo";
            // 
            // lTarjeta
            // 
            this.lTarjeta.AutoSize = true;
            this.lTarjeta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mtarjeta", true));
            this.lTarjeta.Location = new System.Drawing.Point(286, 95);
            this.lTarjeta.Name = "lTarjeta";
            this.lTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lTarjeta.TabIndex = 34;
            this.lTarjeta.Text = "Tarjeta";
            // 
            // ltotalefe
            // 
            this.ltotalefe.AutoSize = true;
            this.ltotalefe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corte00BindingSource, "mtotalefectivo", true));
            this.ltotalefe.Location = new System.Drawing.Point(286, 150);
            this.ltotalefe.Name = "ltotalefe";
            this.ltotalefe.Size = new System.Drawing.Size(72, 13);
            this.ltotalefe.TabIndex = 36;
            this.ltotalefe.Text = "Total efectivo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Total Efectivo:";
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 291);
            this.Controls.Add(this.ltotalefe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lTarjeta);
            this.Controls.Add(this.lEfectivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lGastos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lCaja);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lMontoVentas);
            this.Controls.Add(this.lMontoPagos);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.txtRetirado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Corte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Corte";
            this.Load += new System.EventHandler(this.Corte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corte00BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagos00BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas00BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos00BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRetirado;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lMontoPagos;
        private System.Windows.Forms.Label lMontoVentas;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lCaja;
        private System.Windows.Forms.Label lGastos;
        private System.Windows.Forms.Label label9;
        private Link link;
        private System.Windows.Forms.BindingSource corte00BindingSource;
        private LinkTableAdapters.corte00TableAdapter corte00TableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource pagos00BindingSource;
        private LinkTableAdapters.pagos00TableAdapter pagos00TableAdapter;
        private System.Windows.Forms.BindingSource ventas00BindingSource;
        private LinkTableAdapters.ventas00TableAdapter ventas00TableAdapter;
        private System.Windows.Forms.BindingSource gastos00BindingSource;
        private LinkTableAdapters.gastos00TableAdapter gastos00TableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lEfectivo;
        private System.Windows.Forms.Label lTarjeta;
        private System.Windows.Forms.Label ltotalefe;
        private System.Windows.Forms.Label label12;
    }
}