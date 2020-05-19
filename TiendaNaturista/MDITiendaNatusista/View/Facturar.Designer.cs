namespace MDITiendaNatusista.View
{
	partial class Facturar
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
			this.label7 = new System.Windows.Forms.Label();
			this.cbxFacProd = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numCan = new System.Windows.Forms.NumericUpDown();
			this.cbxCliFac = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValTotal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtValUnit = new System.Windows.Forms.TextBox();
			this.txtValProd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAgregarFac = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxFacVen = new System.Windows.Forms.ComboBox();
			this.gridFactura = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numCan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFactura)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(157, 77);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(197, 57);
			this.label7.TabIndex = 23;
			this.label7.Text = "Producto";
			// 
			// cbxFacProd
			// 
			this.cbxFacProd.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxFacProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFacProd.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxFacProd.FormattingEnabled = true;
			this.cbxFacProd.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxFacProd.Location = new System.Drawing.Point(416, 81);
			this.cbxFacProd.Margin = new System.Windows.Forms.Padding(6);
			this.cbxFacProd.Name = "cbxFacProd";
			this.cbxFacProd.Size = new System.Drawing.Size(484, 48);
			this.cbxFacProd.TabIndex = 24;
			this.cbxFacProd.SelectedIndexChanged += new System.EventHandler(this.cbxFacProd_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(161, 163);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 57);
			this.label1.TabIndex = 25;
			this.label1.Text = "Cantidad";
			// 
			// numCan
			// 
			this.numCan.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numCan.Location = new System.Drawing.Point(416, 163);
			this.numCan.Margin = new System.Windows.Forms.Padding(6);
			this.numCan.Name = "numCan";
			this.numCan.ReadOnly = true;
			this.numCan.Size = new System.Drawing.Size(114, 48);
			this.numCan.TabIndex = 0;
			this.numCan.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// cbxCliFac
			// 
			this.cbxCliFac.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxCliFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCliFac.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxCliFac.FormattingEnabled = true;
			this.cbxCliFac.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxCliFac.Location = new System.Drawing.Point(416, 251);
			this.cbxCliFac.Margin = new System.Windows.Forms.Padding(6);
			this.cbxCliFac.Name = "cbxCliFac";
			this.cbxCliFac.Size = new System.Drawing.Size(748, 48);
			this.cbxCliFac.TabIndex = 27;
			this.cbxCliFac.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(198, 247);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 57);
			this.label2.TabIndex = 28;
			this.label2.Text = "Cliente";
			// 
			// txtValTotal
			// 
			this.txtValTotal.Enabled = false;
			this.txtValTotal.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValTotal.Location = new System.Drawing.Point(1529, 860);
			this.txtValTotal.Margin = new System.Windows.Forms.Padding(6);
			this.txtValTotal.Multiline = true;
			this.txtValTotal.Name = "txtValTotal";
			this.txtValTotal.ReadOnly = true;
			this.txtValTotal.Size = new System.Drawing.Size(249, 49);
			this.txtValTotal.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 342);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(328, 57);
			this.label3.TabIndex = 30;
			this.label3.Text = "Valor Productos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(941, 77);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 57);
			this.label4.TabIndex = 31;
			this.label4.Text = "Valor Unit";
			// 
			// txtValUnit
			// 
			this.txtValUnit.Enabled = false;
			this.txtValUnit.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValUnit.Location = new System.Drawing.Point(1163, 81);
			this.txtValUnit.Margin = new System.Windows.Forms.Padding(6);
			this.txtValUnit.Multiline = true;
			this.txtValUnit.Name = "txtValUnit";
			this.txtValUnit.ReadOnly = true;
			this.txtValUnit.Size = new System.Drawing.Size(260, 48);
			this.txtValUnit.TabIndex = 32;
			// 
			// txtValProd
			// 
			this.txtValProd.Enabled = false;
			this.txtValProd.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValProd.Location = new System.Drawing.Point(416, 342);
			this.txtValProd.Margin = new System.Windows.Forms.Padding(6);
			this.txtValProd.Multiline = true;
			this.txtValProd.Name = "txtValProd";
			this.txtValProd.ReadOnly = true;
			this.txtValProd.Size = new System.Drawing.Size(269, 64);
			this.txtValProd.TabIndex = 33;
			this.txtValProd.TextChanged += new System.EventHandler(this.txtValProd_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1289, 860);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(228, 57);
			this.label5.TabIndex = 34;
			this.label5.Text = "Valor Total";
			// 
			// btnAgregarFac
			// 
			this.btnAgregarFac.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarFac.Location = new System.Drawing.Point(802, 330);
			this.btnAgregarFac.Margin = new System.Windows.Forms.Padding(6);
			this.btnAgregarFac.Name = "btnAgregarFac";
			this.btnAgregarFac.Size = new System.Drawing.Size(155, 76);
			this.btnAgregarFac.TabIndex = 35;
			this.btnAgregarFac.Text = "Agregar";
			this.btnAgregarFac.UseVisualStyleBackColor = true;
			this.btnAgregarFac.Click += new System.EventHandler(this.btnAgregarFac_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1203, 247);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(206, 57);
			this.label6.TabIndex = 37;
			this.label6.Text = "Vendedor";
			// 
			// cbxFacVen
			// 
			this.cbxFacVen.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxFacVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFacVen.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxFacVen.FormattingEnabled = true;
			this.cbxFacVen.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxFacVen.Location = new System.Drawing.Point(1409, 251);
			this.cbxFacVen.Margin = new System.Windows.Forms.Padding(6);
			this.cbxFacVen.Name = "cbxFacVen";
			this.cbxFacVen.Size = new System.Drawing.Size(489, 48);
			this.cbxFacVen.TabIndex = 38;
			// 
			// gridFactura
			// 
			this.gridFactura.AllowUserToAddRows = false;
			this.gridFactura.AllowUserToDeleteRows = false;
			this.gridFactura.AllowUserToResizeColumns = false;
			this.gridFactura.AllowUserToResizeRows = false;
			this.gridFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridFactura.BackgroundColor = System.Drawing.Color.Beige;
			this.gridFactura.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.gridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gridFactura.Location = new System.Drawing.Point(7, 491);
			this.gridFactura.Margin = new System.Windows.Forms.Padding(6);
			this.gridFactura.Name = "gridFactura";
			this.gridFactura.ReadOnly = true;
			this.gridFactura.Size = new System.Drawing.Size(1211, 517);
			this.gridFactura.TabIndex = 39;
			this.gridFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFactura_CellContentClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(1517, 921);
			this.button2.Margin = new System.Windows.Forms.Padding(6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(261, 76);
			this.button2.TabIndex = 41;
			this.button2.Text = "Realizar Venta";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Facturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1924, 1014);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.gridFactura);
			this.Controls.Add(this.cbxFacVen);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnAgregarFac);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtValProd);
			this.Controls.Add(this.txtValUnit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtValTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxCliFac);
			this.Controls.Add(this.numCan);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxFacProd);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Facturar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Facturar";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturar_FormClosed);
			this.Load += new System.EventHandler(this.Facturar_Load);
			((System.ComponentModel.ISupportInitialize)(this.numCan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFactura)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxFacProd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCan;
		private System.Windows.Forms.ComboBox cbxCliFac;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtValUnit;
		private System.Windows.Forms.TextBox txtValProd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAgregarFac;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxFacVen;
		private System.Windows.Forms.DataGridView gridFactura;
		private System.Windows.Forms.Button button2;
	}
}