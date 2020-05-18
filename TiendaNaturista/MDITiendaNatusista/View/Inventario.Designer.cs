namespace MDITiendaNatusista.View
{
	partial class Inventario
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
			this.cbxInventarios = new System.Windows.Forms.ComboBox();
			this.btnBuscarInv = new System.Windows.Forms.Button();
			this.gridInventario = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridInventario)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxInventarios
			// 
			this.cbxInventarios.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.cbxInventarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxInventarios.Font = new System.Drawing.Font("Arial", 26.25F);
			this.cbxInventarios.FormattingEnabled = true;
			this.cbxInventarios.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cbxInventarios.Location = new System.Drawing.Point(204, 39);
			this.cbxInventarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cbxInventarios.Name = "cbxInventarios";
			this.cbxInventarios.Size = new System.Drawing.Size(541, 48);
			this.cbxInventarios.TabIndex = 21;
			// 
			// btnBuscarInv
			// 
			this.btnBuscarInv.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarInv.Location = new System.Drawing.Point(784, 39);
			this.btnBuscarInv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnBuscarInv.Name = "btnBuscarInv";
			this.btnBuscarInv.Size = new System.Drawing.Size(232, 58);
			this.btnBuscarInv.TabIndex = 23;
			this.btnBuscarInv.Text = "Buscar";
			this.btnBuscarInv.UseVisualStyleBackColor = true;
			this.btnBuscarInv.Click += new System.EventHandler(this.btnBuscarInv_Click);
			// 
			// gridInventario
			// 
			this.gridInventario.AllowUserToAddRows = false;
			this.gridInventario.AllowUserToDeleteRows = false;
			this.gridInventario.AllowUserToResizeColumns = false;
			this.gridInventario.AllowUserToResizeRows = false;
			this.gridInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridInventario.BackgroundColor = System.Drawing.Color.Beige;
			this.gridInventario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.gridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gridInventario.Location = new System.Drawing.Point(15, 121);
			this.gridInventario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gridInventario.Name = "gridInventario";
			this.gridInventario.ReadOnly = true;
			this.gridInventario.Size = new System.Drawing.Size(1176, 553);
			this.gridInventario.TabIndex = 24;
			// 
			// Inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1206, 689);
			this.Controls.Add(this.gridInventario);
			this.Controls.Add(this.btnBuscarInv);
			this.Controls.Add(this.cbxInventarios);
			this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Inventario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inventario";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventario_FormClosed);
			this.Load += new System.EventHandler(this.Inventario_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridInventario)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxInventarios;
		private System.Windows.Forms.Button btnBuscarInv;
		private System.Windows.Forms.DataGridView gridInventario;
	}
}