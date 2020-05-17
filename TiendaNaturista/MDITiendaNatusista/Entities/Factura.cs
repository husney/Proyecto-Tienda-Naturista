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
		private int cliente;
		private String vendedor;
		private double valorTotal;

		public Factura() { }

		public Factura(int numero, String fecha, int cliente, String vendedor, double valorTotal)
		{
			this.numero = numero;
			this.fecha = fecha;
			this.cliente = cliente;
			this.vendedor = vendedor;
			this.valorTotal = valorTotal;
		}

		public int Numero { get { return this.numero; } set { this.numero = value; } }
		public String Fecha { get { return this.fecha; } set { this.fecha = value; } }
		public int Cliente { get { return this.cliente; } set { this.cliente = value; } }
		public String Vendedor { get { return this.vendedor; } set { this.vendedor = value; } }
		public double ValorTotal { get { return this.valorTotal; } set { this.valorTotal = value; } }

		public override string ToString()
		{
			return this.numero.ToString();
		}



	}
}
