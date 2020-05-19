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
		private int estado;
		private String codigoProducto;
		private int cantidadProducto;
		private String usuarioVendedor;
		private String cliDocumento;

		public DetalleFactura() { }

		public DetalleFactura(int numero, int estado, String codigoProducto, int cantidadProducto, String usuarioVendedor, String cliDocumento)
		{
			this.numero = numero;
			this.codigoProducto = codigoProducto;
			this.cantidadProducto = cantidadProducto;
			this.usuarioVendedor = usuarioVendedor;
			this.cliDocumento = cliDocumento;
		}

		public int Numero { get { return this.numero; } set { this.numero = value; } }
		public int Estado { get { return this.estado; } set { this.estado = value; } }
		public String CodigoProducto { get { return this.codigoProducto; } set { this.codigoProducto = value; } }
		public int CantidadProducto { get { return this.cantidadProducto; } set { this.cantidadProducto = value; } }
		public String UsuarioVendedor { get { return this.usuarioVendedor;  } set { this.usuarioVendedor = value; } }
		public String ClienteDocumento { get { return this.cliDocumento; } set { this.cliDocumento = value; } }

		public override string ToString()
		{
			return this.numero.ToString();
		}

	}
}
