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
			this.txtClaveSistema = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
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
			this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
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
			// txtClaveSistema
			// 
			this.txtClaveSistema.Font = new System.Drawing.Font("Roboto Light", 14.25F);
			this.txtClaveSistema.Location = new System.Drawing.Point(382, 44);
			this.txtClaveSistema.Multiline = true;
			this.txtClaveSistema.Name = "txtClaveSistema";
			this.txtClaveSistema.PasswordChar = '*';
			this.txtClaveSistema.Size = new System.Drawing.Size(218, 32);
			this.txtClaveSistema.TabIndex = 5;
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Roboto Light", 14.25F);
			this.txtUser.Location = new System.Drawing.Point(382, 125);
			this.txtUser.Multiline = true;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(218, 32);
			this.txtUser.TabIndex = 6;
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Barlow Condensed Black", 20.25F, System.Drawing.FontStyle.Bold);
			this.txtPass.Location = new System.Drawing.Point(382, 203);
			this.txtPass.Multiline = true;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(218, 32);
			this.txtPass.TabIndex = 7;
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 352);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.txtClaveSistema);
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
		private System.Windows.Forms.TextBox txtClaveSistema;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
	}
}