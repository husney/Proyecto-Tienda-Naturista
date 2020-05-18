using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
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

		
		public bool registrarProducto(Entities.Producto producto)
		{
			SqlConnection c = con.getConexion();

			//proCodigo proDescripcion proValor proCantidad

			String sql = "INSERT INTO dbo.productos (proCodigo, proDescripcion, proValor, proCantidad) VALUES (@codigo, @descripcion, @valor, @cantidad)";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@codigo", producto.Codigo);
				comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
				comando.Parameters.AddWithValue("@valor", producto.Valor);
				comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);
				comando.ExecuteNonQuery();
				return true;
			}catch(Exception e)
			{
				return false;
			}
			finally
			{
				c.Close();
			}
			
		}

		public  ComboBox llenarProductos(ComboBox datos)
		{
			SqlConnection c = con.getConexion();

			String sql = " SELECT proCodigo, proDescripcion, proValor, proCantidad FROM dbo.productos";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				SqlDataReader lector = comando.ExecuteReader();
				while (lector.Read())
				{
					Entities.Producto prod = new Entities.Producto();
					prod.Codigo = lector.GetValue(0).ToString();
					prod.Descripcion = lector.GetValue(1).ToString();
					prod.Valor = Convert.ToDouble(lector.GetValue(2));
					prod.Cantidad = Convert.ToInt32(lector.GetValue(3));

					datos.Items.Add(prod);
					
				}
				return datos;

			}catch(Exception ex)
			{
				return datos;
			}
			finally
			{
				c.Close();
			}

		}

		public DataTable llenarProdutosGrid()
		{
			SqlConnection c = con.getConexion();
			DataGrid datos = new DataGrid();

			String sql = "SELECT proCodigo as Código, proDescripcion as Descripción, proValor as Valor, proCantidad as Cantidad FROM dbo.productos";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				SqlDataAdapter adaptador = new SqlDataAdapter();
				adaptador.SelectCommand = comando;
				DataTable tabla = new DataTable();
				adaptador.Fill(tabla);
				
				return tabla;

			}catch(Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
			}
		}




	}//finClass
}
