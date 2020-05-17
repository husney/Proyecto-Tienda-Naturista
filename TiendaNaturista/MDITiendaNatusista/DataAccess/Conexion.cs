using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MDITiendaNatusista.DataAccess
{
	class Conexion
	{
		SqlConnection conexion = new SqlConnection("server=HUSNEY; database=tienda_naturista; integrated security=true;");

		public SqlConnection getConexion()
		{
			try
			{
				Console.WriteLine("Conectandoce...");
				conexion.Open();
				Console.WriteLine("Conectado Correctamente");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error al conectar");
			}

			return conexion;
		}
	}
}
