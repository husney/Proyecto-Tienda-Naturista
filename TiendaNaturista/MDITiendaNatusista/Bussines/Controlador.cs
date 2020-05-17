using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MDITiendaNatusista.Bussines
{
	class Controlador 
	{
		DataAccess.Conexion con;

		public Controlador()
		{
			con = new DataAccess.Conexion();
		}

		public bool conectar(String user, String password)
		{
			SqlConnection c = con.getConexion();

			//venUsuario venContraseña
			String sql = "SELECT * FROM dbo.vendedores WHERE venUsuario = @user AND venContraseña = @pass";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@user", user);
				comando.Parameters.AddWithValue("@pass", password);
				SqlDataReader lector = comando.ExecuteReader();
				if (lector.Read())
				{
					String userDb = lector.GetValue(0).ToString();
					String passDb = lector.GetValue(1).ToString();

					if(user.Equals(userDb) && password.Equals(passDb))
					{
						return true;
					}


				}
			}catch(Exception ex)
			{
				Console.WriteLine("Usuario NO encontrado");
				return false;
			}
			finally
			{
				c.Close();

			}
			return false;
		}

		public bool registrarVendedor(String usuario, String contraseña)
		{
			SqlConnection c = con.getConexion();

			String sql = "INSERT INTO dbo.vendedores (venUsuario, venContraseña) VALUES (@user, @pass)";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@user", usuario);
				comando.Parameters.AddWithValue("@pass", contraseña);
				comando.ExecuteNonQuery();
				Console.WriteLine("Registrado correctamente");
				return true;
			}catch(Exception ex)
			{
				return false;
			}
			finally
			{
				c.Close();
			}
			
		}
	}
}
