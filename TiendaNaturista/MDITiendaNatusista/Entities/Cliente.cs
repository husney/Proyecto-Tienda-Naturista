using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDITiendaNatusista.Entities
{
	class Cliente
	{

		private int numero;
		private String documento;
		private String nombre;
		private String direccion;
		private String telefono;
		private String correo;

		public Cliente() { }

		public Cliente(String documento, String nombre, String direccion , String telefono ,String correo)
		{
			
			this.documento = documento;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
		}

		public Cliente(int numero, String documento, String nombre, String direccion, String telefono, String correo)
		{
			this.numero = numero;
			this.documento = documento;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
		}


		public int Numero { get { return this.numero; } set { this.numero = value; } }
		public String Documento { get { return this.documento; } set { this.documento = value; } }
		public String Nombre { get { return this.nombre; } set { this.nombre = value; } }
		public String Direccion { get { return this.direccion; } set { this.direccion = value; } }
		public String Telefono { get { return this.telefono;  } set { this.telefono = value; } }
		public String Correo { get { return this.correo; } set { this.correo = value; } }

		public override string ToString()
		{
			return this.numero.ToString();
		}
	}
}
