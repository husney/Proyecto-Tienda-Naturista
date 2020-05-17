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
	public partial class Registro : Form
	{
		String sysPassword = "tiendaNaturist001";

		public Registro()
		{
			InitializeComponent();
			
		}

		public void regsitrar(String contraseñaSistema, String usuario, String password)
		{
			if(contraseñaSistema == sysPassword)
			{
				DataAccess.Conexion con = new DataAccess.Conexion();
				SqlConnection c = con.getConexion();

				//venUsuario venContraseña

				String sql = "INSERT INTO dbo.vendedores (venUsuario, venContraseña) VALUES (@user, @pass)";

				try
				{
					SqlCommand comando = new SqlCommand(sql, c);
					comando.Parameters.AddWithValue("@user", usuario);
					comando.Parameters.AddWithValue("@pass", password);
					comando.ExecuteNonQuery();
					MessageBox.Show("Registrado Correctamente");
					limpiar();
					this.Close();
				}catch(Exception ex)
				{

				}
				finally
				{
					c.Close();
				}

			}
			else
			{
				MessageBox.Show("!Clave del Sistema incorrecta!");
			}
		}

		private void btnRegistro_Click(object sender, EventArgs e)
		{
			regsitrar(txtClaveSistema.Text, txtUser.Text, txtPass.Text);
		}

		private void limpiar()
		{
			this.txtClaveSistema.Clear();
			this.txtUser.Clear();
			this.txtPass.Clear();
		}
	}
}
