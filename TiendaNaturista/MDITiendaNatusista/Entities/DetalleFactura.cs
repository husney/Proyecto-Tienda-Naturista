using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDITiendaNatusista.Entities
{
	class DetalleFactura
	{
		private int numero;
		private String producto;
		private int cantidad;

		public DetalleFactura() { }

		public DetalleFactura(int numero, String producto, int cantidad)
		{
			this.numero = numero;
			this.producto = producto;
			this.cantidad = cantidad;
		}

		public int Numero { get { return this.numero; } set { this.numero = value; } }
		public String Producto { get { return this.producto; }  set { this.producto = value; } }
		public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }

		public override string ToString()
		{
			return this.numero.ToString();
		}

	}
}
