using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDITiendaNatusista.Entities
{
	class Producto
	{
		private String codigo;
		private String descripcion;
		private double valor;
		private int cantidad;

		public Producto() { }

		public Producto(String codigo, String descripcion, double valor, int cantidad) 
		{
			this.codigo = codigo;
			this.descripcion = descripcion;
			this.valor = valor;
			this.cantidad = cantidad;
		}

		public String Codigo { get { return this.codigo; } set { this.codigo = value; } }
		public String Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
		public double Valor { get { return this.valor; } set { this.valor = value; } }
		public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }

		


		public override string ToString()
		{
			return this.descripcion;
		}
	}
}
