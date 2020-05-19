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
					

					if (user.Equals(userDb) && password.Equals(passDb))
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


		//llenar cbx Productos
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


		public List<Entities.Producto> llenarCbxFac()
		{
			List<Entities.Producto> productos = new List<Entities.Producto>();
			SqlConnection c = con.getConexion();

			

			try
			{
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
			}
			catch (Exception ex)
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


		//----------------------------------
		//Clientes

		//cliNumero, cliDocumento, cliNombre, cliDireccion, cliTelefono, cliCorreo
		public bool registrarCliente(Entities.Cliente cli)
		{
			SqlConnection c = con.getConexion();

			String sql = "INSERT INTO dbo.clientes (cliDocumento, cliNombre, cliDireccion, cliTelefono, cliCorreo) VALUES (@documento, @nombre, @direccion, @telefono, @correo)";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@documento", cli.Documento);
				comando.Parameters.AddWithValue("@nombre", cli.Nombre);
				comando.Parameters.AddWithValue("@direccion", cli.Direccion);
				comando.Parameters.AddWithValue("@telefono", cli.Telefono);
				comando.Parameters.AddWithValue("@correo", cli.Correo);
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

		//Listar Clientes
		/*public DataTable agregarClientes()
		{
			DataTable datos = new DataTable();
			SqlConnection c  = con.getConexion();

			String sql = "SELECT cliNumero AS Número, cliDocumento AS Documento, cliNombre AS Nombre ,cliDireccion AS Dirección, cliTelefono AS Telefono, cliCorreo AS Correo FROM dbo.clientes";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				SqlDataAdapter adaptador = new SqlDataAdapter();
				adaptador.SelectCommand = comando;
				adaptador.Fill(datos);
				return datos;
			}catch(Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
			}

		}*/

		public DataTable agregarClientes(String val, int opt)
		{
			
			String where = "";
			switch (opt)
			{
				
				case 1:
					where = "WHERE cliDocumento = @valor";
					break;

				case 2:
					where = "WHERE cliNumero = @valor";
					break;

				case 3:
					where = "WHERE cliNombre = @valor";
					break;

				case 4:
					where = "WHERE cliDireccion = @valor";
					break;

				case 5:
					where = "WHERE cliTelefono = @valor";
					break;

				case 6:
					where = "WHERE cliCorreo = @valor";
					break;
			}

			DataTable data = new DataTable();
			SqlConnection c = con.getConexion();

			String sql = "SELECT cliNumero AS Numero, cliDocumento AS Documento, cliNombre AS Nombre, cliDireccion AS Dirección, cliTelefono AS Telefono, cliCorreo AS Correo FROM dbo.clientes "+where;

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@valor", val);
				SqlDataAdapter adaptador = new SqlDataAdapter();
				adaptador.SelectCommand = comando;
				adaptador.Fill(data);
				return data;
				
			}
			catch (Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
			}
			
		}

		public Entities.Cliente agregarObjetoCliente(String num)
		{
			SqlConnection c = con.getConexion();

			String sql = "SELECT cliNumero, cliDocumento, cliNombre, cliDireccion, cliTelefono, cliCorreo FROM clientes WHERE cliNumero = @numero";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@numero", num);
				SqlDataReader lector = comando.ExecuteReader();
				if (lector.Read())
				{
					int n = Convert.ToInt32(lector.GetValue(0));
					String doc = lector.GetValue(1).ToString();
					String nom = lector.GetValue(2).ToString();
					String dir = lector.GetValue(3).ToString();
					String tel = lector.GetValue(4).ToString();
					String cor = lector.GetValue(5).ToString();
					return new Entities.Cliente(n, doc, nom, dir, tel, cor);
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

		//cliNumero, cliDocumento, cliNombre, cliDireccion, cliTelefono, cliCorreo
		public bool actualizarCliente(Entities.Cliente cli)
		{
			SqlConnection c = con.getConexion();

			String sql = "UPDATE clientes SET cliDocumento = @documento, cliNombre = @nombre, cliDireccion = @direccion, cliTelefono = @telefono, cliCorreo = @correo WHERE cliNumero = @numero";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@documento", cli.Documento);
				comando.Parameters.AddWithValue("@nombre", cli.Nombre);
				comando.Parameters.AddWithValue("@direccion", cli.Direccion);
				comando.Parameters.AddWithValue("@telefono", cli.Telefono);
				comando.Parameters.AddWithValue("@correo", cli.Correo);
				comando.Parameters.AddWithValue("@numero", cli.Numero);
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

		public bool eliminarCliente(Entities.Cliente cli)
		{
			SqlConnection c = con.getConexion();

			String sql = "DELETE FROM clientes WHERE cliNumero = @numero";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@numero", cli.Numero);
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

		public List<Entities.Cliente> llenarCbxCliente()
		{
			List<Entities.Cliente> clientes = new List<Entities.Cliente>();
			SqlConnection c = con.getConexion();

			String sql = "SELECT cliDocumento, cliNumero, cliNombre, cliDireccion, cliTelefono, cliCorreo FROM clientes";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				SqlDataReader lector = comando.ExecuteReader();
				while (lector.Read())
				{
					String doc = lector.GetValue(0).ToString();
					int num = Convert.ToInt32(lector.GetValue(1));
					String nombre = lector.GetValue(2).ToString();
					String direc = lector.GetValue(3).ToString();
					String tel = lector.GetValue(4).ToString();
					String cor = lector.GetValue(5).ToString();

					clientes.Add(new Entities.Cliente(num, doc, nombre, direc, tel, cor));
						
				}
				return clientes;
			}
			catch (Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
			}
		}
		int rel = 1;

		public bool ingresarFAcDetalle(Entities.Producto pro, Entities.Cliente cli, int cantidad, Entities.Vendedor ven)
		{
			SqlConnection c = con.getConexion();
			c.Close();
			c.Open();

			
			int estado = 0;

			String sql = "INSERT INTO detalleFactura (facEstado, codigoProd, cantidadProd, usuarioVen, cliDocumento, facRel)VALUES ( @estado, @codigoProd, @cantidad, @usuario, @cliente, @relacion )";

			try
			{
				Console.WriteLine(rel + estado + pro.Codigo + cantidad + ven.User + cli.Documento);
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@relacion", rel);
				comando.Parameters.AddWithValue("@estado", estado);
				comando.Parameters.AddWithValue("@codigoProd", pro.Codigo.ToString());
				comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(cantidad));
				comando.Parameters.AddWithValue("@usuario", ven.User.ToString());
				comando.Parameters.AddWithValue("@cliente", cli.Documento.ToString());
				
				comando.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				c.Close();
			}


		}

		public DataTable gridFacturando()
		{
			SqlConnection c = con.getConexion();
			Console.WriteLine(c.State+"-------------------");
			DataTable facturando = new DataTable();

			String sql = "SELECT detalleFactura.codigoProd AS Código, productos.proDescripcion AS Nombre, detalleFactura.cantidadProd AS Cantidad, detalleFactura.cantidadProd * productos.proValor AS Valor, detalleFactura.usuarioVen AS Vendedor, detalleFactura.cliDocumento AS Cliente"+
						"FROM detalleFactura INNER JOIN productos ON productos.proCodigo = detalleFactura.codigoProd WHERE detalleFactura.facRel = @rel";

			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				comando.Parameters.AddWithValue("@rel", rel);
				SqlDataAdapter adaptador = new SqlDataAdapter();
				adaptador.SelectCommand = comando;
				adaptador.Fill(facturando);
				return facturando;
			}catch(Exception ex)
			{
				return null;
			}
			finally
			{
				c.Close();
			}
		}

		public List<Entities.Vendedor> cbxVendedores()
		{
			List<Entities.Vendedor> vendedores = new List<Entities.Vendedor>();
			SqlConnection c = con.getConexion();
			vendedores.Add(new Entities.Vendedor("Seleccione el vendedor", ""));

			String sql = "SELECT venUsuario, venContraseña FROM vendedores;";
			
			try
			{
				SqlCommand comando = new SqlCommand(sql, c);
				SqlDataReader lector = comando.ExecuteReader();
				while(lector.Read()){
					String us = lector.GetValue(0).ToString();
					Entities.Vendedor ven = new Entities.Vendedor();
					ven.User = us;
					vendedores.Add(ven);

				}
				return vendedores;
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{

			}
		}

		

	}//finClass
}
