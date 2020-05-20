namespace MDITiendaNatusista.View
{
	partial class Factura
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
			this.lblIntro = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.facNumero = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.facFecha = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.facVendedor = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.facCliente = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.facTotal = new System.Windows.Forms.Label();
			this.gridFactura = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridFactura)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIntro
			// 
			this.lblIntro.AutoSize = true;
			this.lblIntro.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.lblIntro.Location = new System.Drawing.Point(17, 18);
			this.lblIntro.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(276, 57);
			this.lblIntro.TabIndex = 0;
			this.lblIntro.Text = "Healthy Shop";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(376, 36);
			this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Factura N°";
			// 
			// facNumero
			// 
			this.facNumero.AutoSize = true;
			this.facNumero.Location = new System.Drawing.Point(524, 36);
			this.facNumero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.facNumero.Name = "facNumero";
			this.facNumero.Size = new System.Drawing.Size(27, 33);
			this.facNumero.TabIndex = 2;
			this.facNumero.Text = "x";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 132);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 33);
			this.label1.TabIndex = 3;
			this.label1.Text = "Fecha:";
			// 
			// facFecha
			// 
			this.facFecha.AutoSize = true;
			this.facFecha.Location = new System.Drawing.Point(159, 132);
			this.facFecha.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.facFecha.Name = "facFecha";
			this.facFecha.Size = new System.Drawing.Size(27, 33);
			this.facFecha.TabIndex = 4;
			this.facFecha.Text = "x";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 181);
			this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "Vendedor:";
			// 
			// facVendedor
			// 
			this.facVendedor.AutoSize = true;
			this.facVendedor.Location = new System.Drawing.Point(159, 181);
			this.facVendedor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.facVendedor.Name = "facVendedor";
			this.facVendedor.Size = new System.Drawing.Size(27, 33);
			this.facVendedor.TabIndex = 6;
			this.facVendedor.Text = "x";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 224);
			this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 33);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cliente:";
			// 
			// facCliente
			// 
			this.facCliente.AutoSize = true;
			this.facCliente.Location = new System.Drawing.Point(159, 224);
			this.facCliente.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.facCliente.Name = "facCliente";
			this.facCliente.Size = new System.Drawing.Size(27, 33);
			this.facCliente.TabIndex = 8;
			this.facCliente.Text = "x";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(348, 611);
			this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 33);
			this.label5.TabIndex = 9;
			this.label5.Text = "Total:";
			// 
			// facTotal
			// 
			this.facTotal.AutoSize = true;
			this.facTotal.Location = new System.Drawing.Point(423, 611);
			this.facTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.facTotal.Name = "facTotal";
			this.facTotal.Size = new System.Drawing.Size(27, 33);
			this.facTotal.TabIndex = 10;
			this.facTotal.Text = "x";
			// 
			// gridFactura
			// 
			this.gridFactura.AllowUserToAddRows = false;
			this.gridFactura.AllowUserToDeleteRows = false;
			this.gridFactura.AllowUserToOrderColumns = true;
			this.gridFactura.AllowUserToResizeColumns = false;
			this.gridFactura.AllowUserToResizeRows = false;
			this.gridFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridFactura.BackgroundColor = System.Drawing.Color.Beige;
			this.gridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFactura.Location = new System.Drawing.Point(27, 279);
			this.gridFactura.Name = "gridFactura";
			this.gridFactura.ReadOnly = true;
			this.gridFactura.Size = new System.Drawing.Size(574, 304);
			this.gridFactura.TabIndex = 11;
			// 
			// Factura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(158)))));
			this.ClientSize = new System.Drawing.Size(613, 653);
			this.Controls.Add(this.gridFactura);
			this.Controls.Add(this.facTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.facCliente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.facVendedor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.facFecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.facNumero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblIntro);
			this.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8);
			this.Name = "Factura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fac";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fac_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.gridFactura)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblIntro;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label facNumero;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label facFecha;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label facVendedor;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label facCliente;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label facTotal;
		public System.Windows.Forms.DataGridView gridFactura;
	}
}