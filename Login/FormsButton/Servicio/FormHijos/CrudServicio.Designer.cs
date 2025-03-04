﻿namespace Presentacion.FormsButton.Servicios.FormHijos
{
    partial class CrudServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgvCrudServicio = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarPaciente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDown = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbItbis = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pdImprimir = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCrudServicio)).BeginInit();
            this.pnTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnDown.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(1023, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(287, 92);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(727, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(296, 92);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgvCrudServicio
            // 
            this.dtgvCrudServicio.AllowUserToAddRows = false;
            this.dtgvCrudServicio.AllowUserToOrderColumns = true;
            this.dtgvCrudServicio.AllowUserToResizeColumns = false;
            this.dtgvCrudServicio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvCrudServicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCrudServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvCrudServicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCrudServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.dtgvCrudServicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvCrudServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCrudServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCrudServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCrudServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Paciente,
            this.Servicio,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Descuento,
            this.SubTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCrudServicio.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvCrudServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCrudServicio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.dtgvCrudServicio.Location = new System.Drawing.Point(0, 342);
            this.dtgvCrudServicio.Name = "dtgvCrudServicio";
            this.dtgvCrudServicio.RowHeadersVisible = false;
            this.dtgvCrudServicio.RowHeadersWidth = 62;
            this.dtgvCrudServicio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvCrudServicio.RowTemplate.Height = 33;
            this.dtgvCrudServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCrudServicio.Size = new System.Drawing.Size(1314, 294);
            this.dtgvCrudServicio.TabIndex = 0;
            this.dtgvCrudServicio.TabStop = false;
            this.dtgvCrudServicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgvCrudServicio_MouseDown);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 79;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 8;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 151;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.MinimumWidth = 8;
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Width = 148;
            // 
            // Precio
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 126;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 158;
            // 
            // Importe
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle5;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 148;
            // 
            // Descuento
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle6;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 8;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 173;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 155;
            // 
            // txtCosto
            // 
            this.txtCosto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCosto.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.ForeColor = System.Drawing.Color.Silver;
            this.txtCosto.Location = new System.Drawing.Point(0, 0);
            this.txtCosto.Multiline = true;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(211, 53);
            this.txtCosto.TabIndex = 10;
            this.txtCosto.Text = "PRECIO:";
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_Enter);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCantidad.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.ForeColor = System.Drawing.Color.Silver;
            this.txtCantidad.Location = new System.Drawing.Point(211, 0);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(211, 53);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.Text = "CANTIDAD:";
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Image = global::Presentacion.Properties.Resources.Agregar;
            this.btnAgregar.Location = new System.Drawing.Point(748, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(296, 83);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = " ADICIONAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpiar.Image = global::Presentacion.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(1044, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(266, 83);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = " LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDescuento.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescuento.ForeColor = System.Drawing.Color.Silver;
            this.txtDescuento.Location = new System.Drawing.Point(422, 0);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(214, 53);
            this.txtDescuento.TabIndex = 20;
            this.txtDescuento.Text = "DESCUENTO:";
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            this.txtDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // cbServicio
            // 
            this.cbServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServicio.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbServicio.ForeColor = System.Drawing.Color.Silver;
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "PROFILAXIS SIMPLE + PULIDO",
            "PROFILAXIS PROFUNDA + PULIDO",
            "CLASE I SIMPLE",
            "CLASE II SIMPLE",
            "CLASE I AMPLIA",
            "CLASE II AMPLIA",
            "CLASE III",
            "CLASE IV SIMPLE",
            "CLASE IV AMPLIA",
            "CLASE V",
            "BASE CAVITARIA",
            "CURA ANALGESICA",
            "RADIOGRAFIAS",
            "EXTRACCIONES SIMPLES (RESTOS)",
            "EXTRACCIONES COLGAJOS",
            "3ER MOLAR SIMPLE",
            "3ER MOLAR RETENIDO",
            "3ER MOLAR SEMI RETENIDO",
            "ENDODONCIA EN ANTERIOR",
            "ENDODONCIA EN PREMOLAR",
            "ENDODONCIA EN MOLAR",
            "INSTALACION DE ORTODONCIA",
            "CONTROL DE ORTODONCIA",
            "BRAKECT DESPEGADO",
            "CEMENTACION IONOMERO DE VIDRIO",
            "CEMENTA.ACRILICO O PORCELANA HASTA 5 PIEZAS",
            "RECONSTRUCCION",
            "TOMA DE  IMPRESIÓN ",
            "PERNO DE FIBRA DE VIDRIO",
            "VALPLAST UNILATERAL",
            "VALPLAST DE 2-4 PIEZAS",
            "VALPLAST DE 6-8 PIEZAS",
            "VALPLAST DE 9 PIEZAS EN ADELA",
            "PARCIAL UNILATERAL",
            "PARCIAL DE 2-4 PIEZAS",
            "PARCIAL DE 5-9 PIEZAS",
            "PARCIAL DE 10 PIEZAS EN ADELANTE",
            "ARMAZON METALICO DE 2 PIEZAS",
            "ARMAZON METALICO DE 3 PIEZAS",
            "ARMAZON METALICO DE 4 PIEZAS",
            "ARMAZON METALICO DE 5 PIEZAS",
            "ARMAZON METALICO DE 6 PIEZAS",
            "ARMAZON METALICO DE 7 PIEZAS",
            "ARMAZON METALICO DE 8 PIEZAS",
            "ARMAZON METALICO DE 9 PIEZAS",
            "ARMAZON METALICO DE 10 PIEZAS",
            "ARMAZON METALICO DE 11 PIEZAS",
            "ARMAZON METALICO DE 2 PIEZAS",
            "ARMAZON METALICO DE 2 PIEZAS",
            "ARMAZON METALICO DE 2 PIEZAS",
            "BLANQUEAMIENTO DENTAL",
            "APLICACION DE FLUOR",
            "SELLANTES DE FOSAS Y FISURAS",
            "EXTRACCIONES DESIDUAS",
            "PERNO COLADO",
            "CORONA DE PORCELANA",
            "CORONA DE ZIRCONIA",
            "CORONA EN ACRILICO",
            "PLACAS MIORELAJANTES",
            "RETENEDOR EN METAL",
            "CEMENTACION CON DICAL",
            "REGULARIZACION OSEA",
            "PROTESIS TOTAL SUP E INFE",
            "DESOBTURAR"});
            this.cbServicio.Location = new System.Drawing.Point(0, 0);
            this.cbServicio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(1310, 48);
            this.cbServicio.TabIndex = 5;
            this.cbServicio.Text = "SERVICIO:";
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            this.cbServicio.Enter += new System.EventHandler(this.cbServicio_Enter);
            this.cbServicio.Leave += new System.EventHandler(this.cbServicio_Leave);
            // 
            // pnTop
            // 
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTop.Controls.Add(this.btnAgregar);
            this.pnTop.Controls.Add(this.btnLimpiar);
            this.pnTop.Controls.Add(this.panel4);
            this.pnTop.Controls.Add(this.panel5);
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1314, 342);
            this.pnTop.TabIndex = 16;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDescuento);
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Controls.Add(this.txtCosto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1310, 53);
            this.panel4.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbServicio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1310, 56);
            this.panel5.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCargarPaciente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 110);
            this.panel2.TabIndex = 32;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnCargarPaciente
            // 
            this.btnCargarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarPaciente.FlatAppearance.BorderSize = 5;
            this.btnCargarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCargarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCargarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPaciente.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPaciente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCargarPaciente.Image = global::Presentacion.Properties.Resources.Cargar1;
            this.btnCargarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnCargarPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCargarPaciente.Name = "btnCargarPaciente";
            this.btnCargarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCargarPaciente.Size = new System.Drawing.Size(1310, 91);
            this.btnCargarPaciente.TabIndex = 1;
            this.btnCargarPaciente.Text = "  CARGAR PACIENTE";
            this.btnCargarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargarPaciente.UseVisualStyleBackColor = true;
            this.btnCargarPaciente.Click += new System.EventHandler(this.btnCargarPaciente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 36);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pnDown
            // 
            this.pnDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDown.Controls.Add(this.btnImprimir);
            this.pnDown.Controls.Add(this.btnGuardar);
            this.pnDown.Controls.Add(this.btnCancelar);
            this.pnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDown.Location = new System.Drawing.Point(0, 727);
            this.pnDown.Name = "pnDown";
            this.pnDown.Size = new System.Drawing.Size(1314, 96);
            this.pnDown.TabIndex = 17;
            this.pnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDown_MouseDown);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(424, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(303, 92);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = " IMPRIMIR";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbItbis);
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 636);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1314, 91);
            this.panel3.TabIndex = 41;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblResultado.Font = new System.Drawing.Font("Sitka Text", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultado.Location = new System.Drawing.Point(294, 0);
            this.lblResultado.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(196, 98);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(294, 104);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total =";
            // 
            // cbItbis
            // 
            this.cbItbis.AutoSize = true;
            this.cbItbis.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbItbis.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbItbis.ForeColor = System.Drawing.Color.White;
            this.cbItbis.Location = new System.Drawing.Point(490, 0);
            this.cbItbis.Name = "cbItbis";
            this.cbItbis.Size = new System.Drawing.Size(344, 87);
            this.cbItbis.TabIndex = 43;
            this.cbItbis.Text = "APLICAR ITBIS (18%)";
            this.cbItbis.UseVisualStyleBackColor = true;
            this.cbItbis.CheckStateChanged += new System.EventHandler(this.cbItbis_CheckStateChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Presentacion.Properties.Resources.trash_solid;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(1209, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 87);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CrudServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1314, 823);
            this.Controls.Add(this.dtgvCrudServicio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearServicio";
            this.Load += new System.EventHandler(this.CrudServicio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CrudServicio_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCrudServicio)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnDown.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dtgvCrudServicio;
        private TextBox txtCosto;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtDescuento;
        private ComboBox cbServicio;
        private Panel pnTop;
        private Panel pnDown;
        private Button btnCargarPaciente;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lblResultado;
        private Label lblTotal;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn SubTotal;
        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument pdImprimir;
        private CheckBox cbItbis;
        private Panel panel4;
        private Panel panel5;
    }
}