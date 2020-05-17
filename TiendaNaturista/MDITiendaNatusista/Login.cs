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
			DataAccess.Conexion con = new DataAccess.Conexion();
			SqlConnection c = con.getConexion();

			/*venUsuario
				venContraseña*/
			String sql = "SELECT * FROM dbo.vendedores WHERE venUsuario = @user AND venContraseña = @pass";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@user", txtUsuario.Text);
				comando.Parameters.AddWithValue("@pass", txtContraseña.Text);
				SqlDataReader lector = comando.ExecuteReader();
				if (lector.Read())
				{
					Console.WriteLine(lector.GetValue(0));
					Console.WriteLine(lector.GetValue(1));
					MessageBox.Show("Usuario Encontrado");
					PrincipalView p = new PrincipalView();
					p.Visible = true;
					

				}
				else
				{
					MessageBox.Show("Usuario o Contraseña incorrectos");
				}
			}catch(Exception ex)
			{
				
			}
			finally
			{
				c.Close();
			}
			
		}

		private void Login_Load(object sender, EventArgs e)
		{
			
		}
	}
}



