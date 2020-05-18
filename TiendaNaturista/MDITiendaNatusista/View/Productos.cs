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
	public partial class Productos : Form
	{
		private Bussines.Controlador controller;

		public Productos()
		{
			controller = new Bussines.Controlador();
			InitializeComponent();
			ComboBox prod = controller.llenarProductos(this.cbxProductos);
			this.cbxProductos = prod;
			
			

			DataTable tabla = controller.llenarProdutosGrid();
			this.gridTabla.DataSource = tabla;
			

			this.gridModificarProd.DataSource = controller.llenarProdutosGrid();

			


		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();
			
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (this.txtCodigo.Text == "" && this.txtDescripcion.Text == "" && this.txtValor.Text == "" && this.txtCantidad.Text == "")
			{
				MessageBox.Show("Por favor ingrese los datos requeridos");
			} else if (this.txtCodigo.Text == "")
			{
				MessageBox.Show("Por favor ingrese el código del producto");
			} else if (this.txtDescripcion.Text == "")
			{
				MessageBox.Show("Por favor ingrese la descripción del producto");
			} else if (this.txtValor.Text == "")
			{
				MessageBox.Show("Porfavor ingrese el valor de producto");
			} else if (this.txtCantidad.Text == "")
			{
				MessageBox.Show("Por favor ingrese la cantidad del producto");
			}
			else
			{
				
				
				if(controller.registrarProducto(new Entities.Producto(this.txtCodigo.Text, this.txtDescripcion.Text, Convert.ToDouble(this.txtValor.Text), Convert.ToInt32(this.txtCantidad.Text))))
				{
					MessageBox.Show("Producto Registrado");
					limpiar();

				}
				else
				{
					MessageBox.Show("Error al registrar producto");
				}
			}
		}

		private void Productos_Load(object sender, EventArgs e)
		{
			
		}

		private void limpiar()
		{
			this.txtCodigo.Clear();
			this.txtDescripcion.Clear();
			this.txtValor.Clear();
			this.txtCantidad.Clear();
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Entities.Producto pro = (Entities.Producto)this.cbxProductos.SelectedItem;

			if(pro.Descripcion == "Todos")
			{
				gridTabla.DataSource = controller.llenarProdutosGrid();
			}
			else { 
			this.gridTabla.DataSource = controller.llenarProductosGrid(pro);
			}
		}

		private void gridTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			

			
			
		}

		private void gridModificarProd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			String valor = this.gridModificarProd.CurrentCell.Value.ToString();

			Entities.Producto prod = controller.llenarUpdateProd(valor);

			try { 
			this.txtUpdCodigo.Text = prod.Codigo;
			this.txtUpdDescripcion.Text = prod.Descripcion;
			this.txtUpdValor.Text = Convert.ToString(prod.Valor);
			this.txtUpdCantidad.Text = Convert.ToString(prod.Cantidad);
			}catch(Exception ex)
			{
				MessageBox.Show("Seleccione el Código del producto");
			}




		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
