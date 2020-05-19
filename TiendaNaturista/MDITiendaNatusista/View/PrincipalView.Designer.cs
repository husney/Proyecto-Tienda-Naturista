namespace MDITiendaNatusista
{
	partial class PrincipalView
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalView));
			this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPrincipalToolStripMenuItem
			// 
			this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.facturarToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem});
			this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
			this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
			this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
			// 
			// facturarToolStripMenuItem
			// 
			this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
			this.facturarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.facturarToolStripMenuItem.Text = "Facturar";
			this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
			// 
			// inventarioToolStripMenuItem
			// 
			this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
			this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.inventarioToolStripMenuItem.Text = "Inventario";
			this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(778, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// PrincipalView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(778, 551);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PrincipalView";
			this.Text = "Healthy Shop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalView_FormClosed);
			this.Load += new System.EventHandler(this.PrincipalView_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
	}
}

