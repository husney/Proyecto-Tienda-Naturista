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
			if(this.txtClaveSistema.Text == "" && this.txtUser.Text == "" && this.txtPass.Text =="")
			{
				MessageBox.Show("Por favor ingrese los valores correspondientes");
			}
			else if(this.txtClaveSistema.Text == "")
			{
				MessageBox.Show("Porfavor ingrese la clave del sistema");
			}
			else if(this.txtUser.Text == "")
			{
				MessageBox.Show("Por favor ingrese el usuario");
			}else if(this.txtPass.Text == "")
			{
				MessageBox.Show("Porfavor ingrese la contraseña");
			}
			else { 

			if(contraseñaSistema == sysPassword)
			{
				Bussines.Controlador con = new Bussines.Controlador();

					if (con.registrarVendedor(usuario, password))
					{
						MessageBox.Show("Registrado correctamente");
						limpiar();
					}
					else
					{
						MessageBox.Show("Error en el registro");
					}


				}
				else
				{
					MessageBox.Show("Clave del sistema incorrecta");
				}


				/*DataAccess.Conexion con = new DataAccess.Conexion();
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
				MessageBox.Show("!Clave del Sistema incorrecta!");*/
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

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();
		}
	}
}
