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
			this.gridFacturando = new System.Windows.Forms.DataGridView();
			this.txtValTotal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtValUnit = new System.Windows.Forms.TextBox();
			this.txtValProd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAgregarFac = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxFacVen = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numCan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFacturando)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 30);
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
			this.cbxFacProd.Location = new System.Drawing.Point(227, 40);
			this.cbxFacProd.Name = "cbxFacProd";
			this.cbxFacProd.Size = new System.Drawing.Size(266, 48);
			this.cbxFacProd.TabIndex = 24;
			this.cbxFacProd.SelectedIndexChanged += new System.EventHandler(this.cbxFacProd_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 57);
			this.label1.TabIndex = 25;
			this.label1.Text = "Cantidad";
			// 
			// numCan
			// 
			this.numCan.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numCan.Location = new System.Drawing.Point(227, 105);
			this.numCan.Name = "numCan";
			this.numCan.ReadOnly = true;
			this.numCan.Size = new System.Drawing.Size(62, 48);
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
			this.cbxCliFac.Location = new System.Drawing.Point(227, 162);
			this.cbxCliFac.Name = "cbxCliFac";
			this.cbxCliFac.Size = new System.Drawing.Size(602, 48);
			this.cbxCliFac.TabIndex = 27;
			this.cbxCliFac.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(65, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 57);
			this.label2.TabIndex = 28;
			this.label2.Text = "Cliente";
			// 
			// gridFacturando
			// 
			this.gridFacturando.AllowUserToAddRows = false;
			this.gridFacturando.AllowUserToDeleteRows = false;
			this.gridFacturando.AllowUserToResizeColumns = false;
			this.gridFacturando.AllowUserToResizeRows = false;
			this.gridFacturando.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridFacturando.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridFacturando.BackgroundColor = System.Drawing.Color.Beige;
			this.gridFacturando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFacturando.Location = new System.Drawing.Point(12, 310);
			this.gridFacturando.Name = "gridFacturando";
			this.gridFacturando.ReadOnly = true;
			this.gridFacturando.Size = new System.Drawing.Size(866, 339);
			this.gridFacturando.TabIndex = 29;
			// 
			// txtValTotal
			// 
			this.txtValTotal.Enabled = false;
			this.txtValTotal.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValTotal.Location = new System.Drawing.Point(1231, 528);
			this.txtValTotal.Multiline = true;
			this.txtValTotal.Name = "txtValTotal";
			this.txtValTotal.ReadOnly = true;
			this.txtValTotal.Size = new System.Drawing.Size(192, 46);
			this.txtValTotal.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(328, 57);
			this.label3.TabIndex = 30;
			this.label3.Text = "Valor Productos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(513, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 57);
			this.label4.TabIndex = 31;
			this.label4.Text = "Valor Unit";
			// 
			// txtValUnit
			// 
			this.txtValUnit.Enabled = false;
			this.txtValUnit.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValUnit.Location = new System.Drawing.Point(729, 40);
			this.txtValUnit.Multiline = true;
			this.txtValUnit.Name = "txtValUnit";
			this.txtValUnit.ReadOnly = true;
			this.txtValUnit.Size = new System.Drawing.Size(192, 46);
			this.txtValUnit.TabIndex = 32;
			// 
			// txtValProd
			// 
			this.txtValProd.Enabled = false;
			this.txtValProd.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValProd.Location = new System.Drawing.Point(375, 229);
			this.txtValProd.Multiline = true;
			this.txtValProd.Name = "txtValProd";
			this.txtValProd.ReadOnly = true;
			this.txtValProd.Size = new System.Drawing.Size(192, 46);
			this.txtValProd.TabIndex = 33;
			this.txtValProd.TextChanged += new System.EventHandler(this.txtValProd_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(997, 518);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(228, 57);
			this.label5.TabIndex = 34;
			this.label5.Text = "Valor Total";
			// 
			// btnAgregarFac
			// 
			this.btnAgregarFac.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarFac.Location = new System.Drawing.Point(592, 227);
			this.btnAgregarFac.Name = "btnAgregarFac";
			this.btnAgregarFac.Size = new System.Drawing.Size(164, 57);
			this.btnAgregarFac.TabIndex = 35;
			this.btnAgregarFac.Text = "Agregar";
			this.btnAgregarFac.UseVisualStyleBackColor = true;
			this.btnAgregarFac.Click += new System.EventHandler(this.btnAgregarFac_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(851, 153);
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
			this.cbxFacVen.Location = new System.Drawing.Point(1049, 153);
			this.cbxFacVen.Name = "cbxFacVen";
			this.cbxFacVen.Size = new System.Drawing.Size(429, 48);
			this.cbxFacVen.TabIndex = 38;
			// 
			// Facturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1523, 661);
			this.Controls.Add(this.cbxFacVen);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnAgregarFac);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtValProd);
			this.Controls.Add(this.txtValUnit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtValTotal);
			this.Controls.Add(this.gridFacturando);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxCliFac);
			this.Controls.Add(this.numCan);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxFacProd);
			this.Controls.Add(this.label7);
			this.Name = "Facturar";
			this.Text = "Facturar";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturar_FormClosed);
			this.Load += new System.EventHandler(this.Facturar_Load);
			((System.ComponentModel.ISupportInitialize)(this.numCan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFacturando)).EndInit();
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
		private System.Windows.Forms.DataGridView gridFacturando;
		private System.Windows.Forms.TextBox txtValTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtValUnit;
		private System.Windows.Forms.TextBox txtValProd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAgregarFac;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxFacVen;
	}
}