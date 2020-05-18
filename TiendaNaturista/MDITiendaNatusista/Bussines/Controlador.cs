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


		public List<Entities.Producto> llenarCbx()
		{
			List<Entities.Producto> productos = new List<Entities.Producto>();
			SqlConnection c = con.getConexion();

			productos.Add(new Entities.Producto("", "Todos", 0, 0));

			try { 
			String sql = "SELECT proCodigo, proDescripcion, proValor, proCantidad FROM dbo.productos";

			SqlCommand comando = new SqlCommand(sql, c);
			SqlDataReader lector = comando.ExecuteReader();


			while (lector.Read())
			{
				String cod = lector.GetValue(0).ToString();
				String desc = lector.GetValue(1).ToString();
				double val = Convert.ToDouble(lector.GetValue(2));
				int can = Convert.ToInt32(lector.GetValue(3));
				productos.Add(new Entities.Producto(cod, desc, val, can));
			}
			return productos;
			}catch(Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
				
			}

		}
		

	

		



		//Productos
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
				DataTable d = new DataTable();
				return d;
			}
			finally
			{
				c.Close();
			}
		}

		//Productos
		public DataTable llenarProductosGrid(Entities.Producto prod)
		{
			SqlConnection c = con.getConexion();
			DataTable tabla = new DataTable();
			
			String sql = "SELECT proCodigo as Código, proDescripcion as Descripción, proValor as Valor, proCantidad as Cantidad FROM dbo.productos WHERE proDescripcion = @descripcion";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
				SqlDataAdapter adaptador = new SqlDataAdapter();
				adaptador.SelectCommand = comando;
				adaptador.Fill(tabla);
				return tabla;
			}
			catch (Exception ex){
				return tabla;
			}
			finally
			{
				c.Close();
			}

		}

		//Buscar Update Productos
		public Entities.Producto llenarObjProduct(String codigo)
		{
			SqlConnection c = con.getConexion();

			String sql = "SELECT proCodigo, proDescripcion, proValor, proCantidad FROM dbo.productos WHERE proCodigo = @codigo";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@codigo", codigo);
				SqlDataReader lector = comando.ExecuteReader();
				if (lector.Read())
				{
					String cod = lector.GetValue(0).ToString();
					String descripcion = lector.GetValue(1).ToString();
					double val = Convert.ToDouble(lector.GetValue(2).ToString());
					int cant = Convert.ToInt32(lector.GetValue(3).ToString());

					return new Entities.Producto(cod, descripcion, val, cant);
				}
			}catch(Exception ex)
			{
				return null;
			}
			finally
			{

				c.Close();
				
			}
			return null;

		}


		public bool actualizarProd(Entities.Producto prod)
		{

			SqlConnection c = con.getConexion();

			String sql = "UPDATE dbo.productos SET proDescripcion = @descripcion, proValor = @valor, proCantidad = @cantidad WHERE proCodigo = @codigo";

			try
			{
				SqlCommand comando = new SqlCommand(sql , c);
				comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
				comando.Parameters.AddWithValue("@valor", prod.Valor);
				comando.Parameters.AddWithValue("@cantidad", prod.Cantidad);
				comando.Parameters.AddWithValue("@codigo", prod.Codigo);
				comando.ExecuteNonQuery();
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

		public bool eliminarProd(Entities.Producto prod)
		{
			SqlConnection c = con.getConexion();

			String sql = "DELETE FROM dbo.productos WHERE proCodigo = @codigo";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@codigo", prod.Codigo);
				comando.ExecuteNonQuery();
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




	}//finClass
}
