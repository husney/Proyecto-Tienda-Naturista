using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDITiendaNatusista.Entities
{
	class Factura
	{

		private int numero;
		private String fecha;
		private String proDescripcion;
		private int cantidad;
		private String vendedor;
		private String cliente;
		private double valorTotal;

		public Factura() { }

		public Factura(int numero, String fecha, String descripcion, int cantidad, String vendedor, String cliente, double valorTotal)
		{
			this.numero = numero;
			this.fecha = fecha;
			this.proDescripcion = descripcion;
			this.cantidad = cantidad;
			this.vendedor = vendedor;
			this.cliente = cliente;
			this.valorTotal = valorTotal;
		}

		public int Numero { get { return this.numero; } set { this.numero = value; } }
		public String Fecha { get { return this.fecha; } set { this.fecha = value; } }
		public String ProductoDescripcion { get { return this.proDescripcion; }  set { this.proDescripcion = value; } }
		public int CantidadProducto { get { return this.cantidad; } set { this.cantidad = value; } }
		public String Cliente { get { return this.cliente; } set { this.cliente = value; } }
		public String Vendedor { get { return this.vendedor; } set { this.vendedor = value; } }
		public double ValorTotal { get { return this.valorTotal; } set { this.valorTotal = value; } }

		public override string ToString()
		{
			return this.numero.ToString();
		}



	}
}
