namespace MDITiendaNatusista.View
{
	partial class Productos
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
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gridTabla = new System.Windows.Forms.DataGridView();
			this.cbxProductos = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gridModificarProd = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.txtUpdCodigo = new System.Windows.Forms.TextBox();
			this.txtUpdDescripcion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUpdValor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtUpdCantidad = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxUpdateProduct = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTabla)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridModificarProd)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = "";
			this.tabControl1.AccessibleName = "";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1174, 578);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(158)))));
			this.tabPage1.Controls.Add(this.btnNuevo);
			this.tabPage1.Controls.Add(this.btnGuardar);
			this.tabPage1.Controls.Add(this.txtCantidad);
			this.tabPage1.Controls.Add(this.txtValor);
			this.tabPage1.Controls.Add(this.txtDescripcion);
			this.tabPage1.Controls.Add(this.txtCodigo);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1166, 540);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ingresar Productos";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(639, 430);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(140, 46);
			this.btnNuevo.TabIndex = 9;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(463, 430);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(140, 46);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(558, 292);
			this.txtCantidad.Multiline = true;
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(380, 45);
			this.txtCantidad.TabIndex = 7;
			// 
			// txtValor
			// 
			this.txtValor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.Location = new System.Drawing.Point(558, 222);
			this.txtValor.Multiline = true;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(380, 45);
			this.txtValor.TabIndex = 6;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(558, 146);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(380, 45);
			this.txtDescripcion.TabIndex = 5;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(558, 63);
			this.txtCodigo.Multiline = true;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(380, 46);
			this.txtCodigo.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(332, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(193, 57);
			this.label5.TabIndex = 3;
			this.label5.Text = "Cantidad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(402, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 57);
			this.label4.TabIndex = 2;
			this.label4.Text = "Valor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(287, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(250, 57);
			this.label3.TabIndex = 1;
			this.label3.Text = "Descripción";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(377, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 57);
			this.label2.TabIndex = 0;
			this.label2.Text = "Código";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(158)))));
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.gridTabla);
			this.tabPage2.Controls.Add(this.cbxProductos);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1166, 540);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Consultar Productos";
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// gridTabla
			// 
			this.gridTabla.AllowUserToAddRows = false;
			this.gridTabla.AllowUserToDeleteRows = false;
			this.gridTabla.AllowUserToResizeColumns = false;
			this.gridTabla.AllowUserToResizeRows = false;
			this.gridTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridTabla.BackgroundColor = System.Drawing.Color.Beige;
			this.gridTabla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.gridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gridTabla.Location = new System.Drawing.Point(5, 132);
			this.gridTabla.Name = "gridTabla";
			this.gridTabla.ReadOnly = true;
			this.gridTabla.Size = new System.Drawing.Size(1154, 402);
			this.gridTabla.TabIndex = 3;
			this.gridTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTabla_CellContentClick);
			// 
			// cbxProductos
			// 
			this.cbxProductos.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProductos.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxProductos.FormattingEnabled = true;
			this.cbxProductos.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxProductos.Location = new System.Drawing.Point(417, 51);
			this.cbxProductos.Name = "cbxProductos";
			this.cbxProductos.Size = new System.Drawing.Size(428, 48);
			this.cbxProductos.TabIndex = 2;
			this.cbxProductos.SelectedIndexChanged += new System.EventHandler(this.cbxProductos_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(214, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(197, 57);
			this.label6.TabIndex = 1;
			this.label6.Text = "Producto";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(158)))));
			this.tabPage3.Controls.Add(this.cbxUpdateProduct);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.txtUpdCantidad);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.txtUpdValor);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.txtUpdDescripcion);
			this.tabPage3.Controls.Add(this.txtUpdCodigo);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.gridModificarProd);
			this.tabPage3.Location = new System.Drawing.Point(4, 34);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1166, 540);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Modificar Productos";
			this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(158)))));
			this.tabPage4.Location = new System.Drawing.Point(4, 34);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1166, 540);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Eliminar productos";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1163, 44);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SeaGreen;
			this.label1.Location = new System.Drawing.Point(477, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Healthy Products";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(865, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 46);
			this.button1.TabIndex = 9;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridModificarProd
			// 
			this.gridModificarProd.AllowUserToAddRows = false;
			this.gridModificarProd.AllowUserToDeleteRows = false;
			this.gridModificarProd.AllowUserToResizeColumns = false;
			this.gridModificarProd.AllowUserToResizeRows = false;
			this.gridModificarProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridModificarProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridModificarProd.BackgroundColor = System.Drawing.Color.Beige;
			this.gridModificarProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.gridModificarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridModificarProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gridModificarProd.Location = new System.Drawing.Point(3, 286);
			this.gridModificarProd.Name = "gridModificarProd";
			this.gridModificarProd.ReadOnly = true;
			this.gridModificarProd.Size = new System.Drawing.Size(1156, 251);
			this.gridModificarProd.TabIndex = 4;
			this.gridModificarProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModificarProd_CellClick);
			this.gridModificarProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(93, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 57);
			this.label7.TabIndex = 6;
			this.label7.Text = "Código";
			// 
			// txtUpdCodigo
			// 
			this.txtUpdCodigo.Enabled = false;
			this.txtUpdCodigo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUpdCodigo.Location = new System.Drawing.Point(259, 20);
			this.txtUpdCodigo.Multiline = true;
			this.txtUpdCodigo.Name = "txtUpdCodigo";
			this.txtUpdCodigo.Size = new System.Drawing.Size(274, 47);
			this.txtUpdCodigo.TabIndex = 7;
			// 
			// txtUpdDescripcion
			// 
			this.txtUpdDescripcion.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUpdDescripcion.Location = new System.Drawing.Point(865, 20);
			this.txtUpdDescripcion.Multiline = true;
			this.txtUpdDescripcion.Name = "txtUpdDescripcion";
			this.txtUpdDescripcion.Size = new System.Drawing.Size(274, 47);
			this.txtUpdDescripcion.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(599, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(250, 57);
			this.label8.TabIndex = 9;
			this.label8.Text = "Descripción";
			// 
			// txtUpdValor
			// 
			this.txtUpdValor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUpdValor.Location = new System.Drawing.Point(259, 86);
			this.txtUpdValor.Multiline = true;
			this.txtUpdValor.Name = "txtUpdValor";
			this.txtUpdValor.Size = new System.Drawing.Size(274, 47);
			this.txtUpdValor.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(130, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 57);
			this.label9.TabIndex = 11;
			this.label9.Text = "Valor";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(656, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(193, 57);
			this.label10.TabIndex = 12;
			this.label10.Text = "Cantidad";
			// 
			// txtUpdCantidad
			// 
			this.txtUpdCantidad.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUpdCantidad.Location = new System.Drawing.Point(865, 86);
			this.txtUpdCantidad.Multiline = true;
			this.txtUpdCantidad.Name = "txtUpdCantidad";
			this.txtUpdCantidad.Size = new System.Drawing.Size(274, 47);
			this.txtUpdCantidad.TabIndex = 13;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(605, 248);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(523, 24);
			this.label11.TabIndex = 14;
			this.label11.Text = "Seleccione el código del producto que desea actualizar";
			// 
			// cbxUpdateProduct
			// 
			this.cbxUpdateProduct.FormattingEnabled = true;
			this.cbxUpdateProduct.Location = new System.Drawing.Point(29, 239);
			this.cbxUpdateProduct.Name = "cbxUpdateProduct";
			this.cbxUpdateProduct.Size = new System.Drawing.Size(317, 33);
			this.cbxUpdateProduct.TabIndex = 15;
			this.cbxUpdateProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1187, 654);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Productos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Productos";
			this.Load += new System.EventHandler(this.Productos_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTabla)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridModificarProd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cbxProductos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView gridTabla;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView gridModificarProd;
		private System.Windows.Forms.TextBox txtUpdDescripcion;
		private System.Windows.Forms.TextBox txtUpdCodigo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtUpdCantidad;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUpdValor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbxUpdateProduct;
	}
}