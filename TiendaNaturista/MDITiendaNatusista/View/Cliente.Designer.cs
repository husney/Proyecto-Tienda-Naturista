namespace MDITiendaNatusista.View
{
	partial class Cliente
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.txtDocumentoCli = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombreCli = new System.Windows.Forms.TextBox();
			this.txtDireccionCli = new System.Windows.Forms.TextBox();
			this.txtTelefonoCli = new System.Windows.Forms.TextBox();
			this.txtCorreoCli = new System.Windows.Forms.TextBox();
			this.btnGuardarCli = new System.Windows.Forms.Button();
			this.btnNuevoCli = new System.Windows.Forms.Button();
			this.txtBuscDocCli = new System.Windows.Forms.TextBox();
			this.gridTablaCli = new System.Windows.Forms.DataGridView();
			this.btnBuscarCli = new System.Windows.Forms.Button();
			this.cbxOp = new System.Windows.Forms.ComboBox();
			this.cbxOpC = new System.Windows.Forms.ComboBox();
			this.gridCliUp = new System.Windows.Forms.DataGridView();
			this.txtNumUp = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtDocUp = new System.Windows.Forms.TextBox();
			this.txtNomUp = new System.Windows.Forms.TextBox();
			this.txtDirUp = new System.Windows.Forms.TextBox();
			this.txtTelUp = new System.Windows.Forms.TextBox();
			this.txtCorUp = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTablaCli)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCliUp)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1024, 647);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
			this.tabPage1.Controls.Add(this.btnNuevoCli);
			this.tabPage1.Controls.Add(this.btnGuardarCli);
			this.tabPage1.Controls.Add(this.txtCorreoCli);
			this.tabPage1.Controls.Add(this.txtTelefonoCli);
			this.tabPage1.Controls.Add(this.txtDireccionCli);
			this.tabPage1.Controls.Add(this.txtNombreCli);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txtDocumentoCli);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1016, 573);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Registar Cliente";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
			this.tabPage2.Controls.Add(this.cbxOpC);
			this.tabPage2.Controls.Add(this.btnBuscarCli);
			this.tabPage2.Controls.Add(this.gridTablaCli);
			this.tabPage2.Controls.Add(this.txtBuscDocCli);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1016, 573);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Buscar Cliente";
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.btnActualizar);
			this.tabPage3.Controls.Add(this.txtCorUp);
			this.tabPage3.Controls.Add(this.txtTelUp);
			this.tabPage3.Controls.Add(this.txtDirUp);
			this.tabPage3.Controls.Add(this.txtNomUp);
			this.tabPage3.Controls.Add(this.txtDocUp);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.txtNumUp);
			this.tabPage3.Controls.Add(this.gridCliUp);
			this.tabPage3.Location = new System.Drawing.Point(4, 34);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1016, 609);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Actualizar Cliente";
			this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
			this.tabPage4.Location = new System.Drawing.Point(4, 34);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1016, 573);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Eliminar Cliente";
			// 
			// txtDocumentoCli
			// 
			this.txtDocumentoCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumentoCli.Location = new System.Drawing.Point(501, 50);
			this.txtDocumentoCli.Multiline = true;
			this.txtDocumentoCli.Name = "txtDocumentoCli";
			this.txtDocumentoCli.Size = new System.Drawing.Size(309, 47);
			this.txtDocumentoCli.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(241, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(241, 57);
			this.label7.TabIndex = 8;
			this.label7.Text = "Documento";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(309, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 57);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(278, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 57);
			this.label2.TabIndex = 11;
			this.label2.Text = "Dirección";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(293, 317);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 57);
			this.label3.TabIndex = 12;
			this.label3.Text = "Telefono";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(329, 398);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 57);
			this.label4.TabIndex = 13;
			this.label4.Text = "Correo";
			// 
			// txtNombreCli
			// 
			this.txtNombreCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCli.Location = new System.Drawing.Point(501, 136);
			this.txtNombreCli.Multiline = true;
			this.txtNombreCli.Name = "txtNombreCli";
			this.txtNombreCli.Size = new System.Drawing.Size(309, 47);
			this.txtNombreCli.TabIndex = 14;
			// 
			// txtDireccionCli
			// 
			this.txtDireccionCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccionCli.Location = new System.Drawing.Point(501, 233);
			this.txtDireccionCli.Multiline = true;
			this.txtDireccionCli.Name = "txtDireccionCli";
			this.txtDireccionCli.Size = new System.Drawing.Size(309, 47);
			this.txtDireccionCli.TabIndex = 15;
			// 
			// txtTelefonoCli
			// 
			this.txtTelefonoCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoCli.Location = new System.Drawing.Point(501, 317);
			this.txtTelefonoCli.Multiline = true;
			this.txtTelefonoCli.Name = "txtTelefonoCli";
			this.txtTelefonoCli.Size = new System.Drawing.Size(309, 47);
			this.txtTelefonoCli.TabIndex = 16;
			// 
			// txtCorreoCli
			// 
			this.txtCorreoCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoCli.Location = new System.Drawing.Point(501, 398);
			this.txtCorreoCli.Multiline = true;
			this.txtCorreoCli.Name = "txtCorreoCli";
			this.txtCorreoCli.Size = new System.Drawing.Size(309, 47);
			this.txtCorreoCli.TabIndex = 17;
			// 
			// btnGuardarCli
			// 
			this.btnGuardarCli.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarCli.Location = new System.Drawing.Point(403, 484);
			this.btnGuardarCli.Name = "btnGuardarCli";
			this.btnGuardarCli.Size = new System.Drawing.Size(166, 51);
			this.btnGuardarCli.TabIndex = 18;
			this.btnGuardarCli.Text = "Registrar";
			this.btnGuardarCli.UseVisualStyleBackColor = true;
			this.btnGuardarCli.Click += new System.EventHandler(this.btnGuardarCli_Click);
			// 
			// btnNuevoCli
			// 
			this.btnNuevoCli.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevoCli.Location = new System.Drawing.Point(598, 484);
			this.btnNuevoCli.Name = "btnNuevoCli";
			this.btnNuevoCli.Size = new System.Drawing.Size(166, 51);
			this.btnNuevoCli.TabIndex = 19;
			this.btnNuevoCli.Text = "Nuevo";
			this.btnNuevoCli.UseVisualStyleBackColor = true;
			this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
			// 
			// txtBuscDocCli
			// 
			this.txtBuscDocCli.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscDocCli.Location = new System.Drawing.Point(396, 40);
			this.txtBuscDocCli.Multiline = true;
			this.txtBuscDocCli.Name = "txtBuscDocCli";
			this.txtBuscDocCli.Size = new System.Drawing.Size(309, 47);
			this.txtBuscDocCli.TabIndex = 10;
			// 
			// gridTablaCli
			// 
			this.gridTablaCli.AllowUserToAddRows = false;
			this.gridTablaCli.AllowUserToDeleteRows = false;
			this.gridTablaCli.AllowUserToResizeColumns = false;
			this.gridTablaCli.AllowUserToResizeRows = false;
			this.gridTablaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridTablaCli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridTablaCli.BackgroundColor = System.Drawing.Color.Beige;
			this.gridTablaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTablaCli.Location = new System.Drawing.Point(6, 103);
			this.gridTablaCli.Name = "gridTablaCli";
			this.gridTablaCli.ReadOnly = true;
			this.gridTablaCli.Size = new System.Drawing.Size(1004, 464);
			this.gridTablaCli.TabIndex = 12;
			// 
			// btnBuscarCli
			// 
			this.btnBuscarCli.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCli.Location = new System.Drawing.Point(732, 36);
			this.btnBuscarCli.Name = "btnBuscarCli";
			this.btnBuscarCli.Size = new System.Drawing.Size(166, 51);
			this.btnBuscarCli.TabIndex = 20;
			this.btnBuscarCli.Text = "Nuevo";
			this.btnBuscarCli.UseVisualStyleBackColor = true;
			this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
			// 
			// cbxOp
			// 
			this.cbxOp.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOp.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxOp.FormattingEnabled = true;
			this.cbxOp.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxOp.Location = new System.Drawing.Point(153, 39);
			this.cbxOp.Name = "cbxOp";
			this.cbxOp.Size = new System.Drawing.Size(220, 48);
			this.cbxOp.TabIndex = 21;
			// 
			// cbxOpC
			// 
			this.cbxOpC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOpC.FormattingEnabled = true;
			this.cbxOpC.Location = new System.Drawing.Point(232, 47);
			this.cbxOpC.Name = "cbxOpC";
			this.cbxOpC.Size = new System.Drawing.Size(146, 33);
			this.cbxOpC.TabIndex = 21;
			this.cbxOpC.SelectedIndexChanged += new System.EventHandler(this.cbxOpC_SelectedIndexChanged);
			// 
			// gridCliUp
			// 
			this.gridCliUp.AllowUserToAddRows = false;
			this.gridCliUp.AllowUserToDeleteRows = false;
			this.gridCliUp.AllowUserToResizeColumns = false;
			this.gridCliUp.AllowUserToResizeRows = false;
			this.gridCliUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridCliUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridCliUp.BackgroundColor = System.Drawing.Color.Beige;
			this.gridCliUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCliUp.Location = new System.Drawing.Point(6, 310);
			this.gridCliUp.Name = "gridCliUp";
			this.gridCliUp.ReadOnly = true;
			this.gridCliUp.Size = new System.Drawing.Size(1004, 293);
			this.gridCliUp.TabIndex = 13;
			this.gridCliUp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliUp_CellClick);
			this.gridCliUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliUp_CellContentClick);
			// 
			// txtNumUp
			// 
			this.txtNumUp.Enabled = false;
			this.txtNumUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumUp.Location = new System.Drawing.Point(253, 24);
			this.txtNumUp.Multiline = true;
			this.txtNumUp.Name = "txtNumUp";
			this.txtNumUp.Size = new System.Drawing.Size(192, 46);
			this.txtNumUp.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(74, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 57);
			this.label5.TabIndex = 15;
			this.label5.Text = "Número";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(241, 57);
			this.label6.TabIndex = 16;
			this.label6.Text = "Documento";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(74, 163);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(173, 57);
			this.label8.TabIndex = 17;
			this.label8.Text = "Nombre";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(476, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(204, 57);
			this.label9.TabIndex = 18;
			this.label9.Text = "Dirección";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(491, 90);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(189, 57);
			this.label10.TabIndex = 19;
			this.label10.Text = "Telefono";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(527, 146);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 57);
			this.label11.TabIndex = 20;
			this.label11.Text = "Correo";
			// 
			// txtDocUp
			// 
			this.txtDocUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocUp.Location = new System.Drawing.Point(253, 90);
			this.txtDocUp.Multiline = true;
			this.txtDocUp.Name = "txtDocUp";
			this.txtDocUp.Size = new System.Drawing.Size(192, 46);
			this.txtDocUp.TabIndex = 21;
			// 
			// txtNomUp
			// 
			this.txtNomUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomUp.Location = new System.Drawing.Point(253, 173);
			this.txtNomUp.Multiline = true;
			this.txtNomUp.Name = "txtNomUp";
			this.txtNomUp.Size = new System.Drawing.Size(192, 46);
			this.txtNomUp.TabIndex = 22;
			// 
			// txtDirUp
			// 
			this.txtDirUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDirUp.Location = new System.Drawing.Point(686, 24);
			this.txtDirUp.Multiline = true;
			this.txtDirUp.Name = "txtDirUp";
			this.txtDirUp.Size = new System.Drawing.Size(192, 46);
			this.txtDirUp.TabIndex = 23;
			// 
			// txtTelUp
			// 
			this.txtTelUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelUp.Location = new System.Drawing.Point(686, 90);
			this.txtTelUp.Multiline = true;
			this.txtTelUp.Name = "txtTelUp";
			this.txtTelUp.Size = new System.Drawing.Size(192, 46);
			this.txtTelUp.TabIndex = 24;
			// 
			// txtCorUp
			// 
			this.txtCorUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorUp.Location = new System.Drawing.Point(686, 156);
			this.txtCorUp.Multiline = true;
			this.txtCorUp.Name = "txtCorUp";
			this.txtCorUp.Size = new System.Drawing.Size(192, 46);
			this.txtCorUp.TabIndex = 25;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(436, 228);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(166, 51);
			this.btnActualizar.TabIndex = 26;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 282);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(533, 25);
			this.label12.TabIndex = 27;
			this.label12.Text = "Seleccione el código numero del cliente que quiere modificar";
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1048, 686);
			this.Controls.Add(this.tabControl1);
			this.Name = "Cliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cliente_FormClosed);
			this.Load += new System.EventHandler(this.Cliente_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTablaCli)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCliUp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox txtCorreoCli;
		private System.Windows.Forms.TextBox txtTelefonoCli;
		private System.Windows.Forms.TextBox txtDireccionCli;
		private System.Windows.Forms.TextBox txtNombreCli;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDocumentoCli;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnNuevoCli;
		private System.Windows.Forms.Button btnGuardarCli;
		private System.Windows.Forms.Button btnBuscarCli;
		private System.Windows.Forms.DataGridView gridTablaCli;
		private System.Windows.Forms.TextBox txtBuscDocCli;
		private System.Windows.Forms.ComboBox cbxOp;
		private System.Windows.Forms.ComboBox cbxOpC;
		private System.Windows.Forms.DataGridView gridCliUp;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCorUp;
		private System.Windows.Forms.TextBox txtTelUp;
		private System.Windows.Forms.TextBox txtDirUp;
		private System.Windows.Forms.TextBox txtNomUp;
		private System.Windows.Forms.TextBox txtDocUp;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNumUp;
	}
}