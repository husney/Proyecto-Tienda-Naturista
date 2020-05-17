namespace MDITiendaNatusista
{
	partial class Registro
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Zilla Slab SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(138, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clave del sistema:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Zilla Slab SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(247, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Zilla Slab SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(204, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña:";
			// 
			// btnRegistro
			// 
			this.btnRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnRegistro.Location = new System.Drawing.Point(253, 282);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(108, 38);
			this.btnRegistro.TabIndex = 3;
			this.btnRegistro.Text = "Registrar";
			this.btnRegistro.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnNuevo.Location = new System.Drawing.Point(382, 282);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(108, 38);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(382, 44);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(218, 32);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(382, 125);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(218, 32);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(382, 203);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(218, 32);
			this.textBox3.TabIndex = 7;
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 352);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Registro";
			this.Text = "Registro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}