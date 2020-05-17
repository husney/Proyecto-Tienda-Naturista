using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDITiendaNatusista.Entities
{
	class Vendedor
	{
		private String usuario;
		private String contraseña;

		public Vendedor() { }

		public Vendedor(String usuario, String contraseña)
		{
			this.usuario = usuario;
			this.contraseña = contraseña;
		}

		public String User { get { return this.usuario; } set { this.usuario = value; } }
		public String Contraseña { get{return this.contraseña;} set { this.contraseña = value; } }


		public override string ToString()
		{
			return this.usuario;
		}
	}
}
