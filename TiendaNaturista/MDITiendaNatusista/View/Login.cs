using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDITiendaNatusista
{
	
	public partial class Login : Form
	{
	
		public Login()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			Registro reg = new Registro();
			reg.Visible = true;
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if(this.txtUsuario.Text == "" && this.txtContraseña.Text == "")
			{
				MessageBox.Show("Por favor ingrese los valores");
			}else if(this.txtUsuario.Text == "")
			{
				MessageBox.Show("Por favor ingrese el usuario");
			}else if(this.txtContraseña.Text == "")
			{
				MessageBox.Show("Por favor ingrese la contraseña");
			}else {

				Bussines.Controlador control = new Bussines.Controlador();

				if(control.conectar(this.txtUsuario.Text, this.txtContraseña.Text) == true)
				{
					PrincipalView pv = new PrincipalView();
					pv.Visible = true;
					this.Hide();
				}
				else
				{
					MessageBox.Show("Usuario o Contraseña incorrectos");
				}
				
			}


		}

		private void Login_Load(object sender, EventArgs e)
		{
			
		}

		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}



