using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITiendaNatusista.View
{
	public partial class Inventario : Form
	{
		private Bussines.Controlador controller;

		public Inventario()
		{
			InitializeComponent();
			controller = new Bussines.Controlador();
			cargarCbx();
			this.gridInventario.DataSource = controller.llenarProdutosGrid();

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Inventario_Load(object sender, EventArgs e)
		{

		}

		private void cargarCbx()
		{
			this.cbxInventarios.DataSource = controller.llenarCbx();
		}

		private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
		}

		private void btnBuscarInv_Click(object sender, EventArgs e)
		{
			Entities.Producto prod = (Entities.Producto)this.cbxInventarios.SelectedItem;

			if(prod.Descripcion == "Todos")
			{
				this.gridInventario.DataSource = controller.llenarProdutosGrid();
			}
			else
			{
				this.gridInventario.DataSource = controller.llenarProductosGrid(prod);
			}
		}
	}
}
