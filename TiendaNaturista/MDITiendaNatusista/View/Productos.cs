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
			InitializeComponent();
			controller = new Bussines.Controlador();
			actualizarTablas();
			actualizarCbx();
			


			
			//ComboBox prod = controller.llenarProductos();
			//this.cbxProductos = prod;

			/*
			this.cbxUpdateProd = controller.llenarProductos(this.cbxUpdateProd);

			DataTable tabla = controller.llenarProdutosGrid();
			this.gridTabla.DataSource = tabla;
			

			this.gridModificarProd.DataSource = controller.llenarProdutosGrid();
			this.gridEliminar.DataSource = controller.llenarProdutosGrid();

			this.cbxEliminar = controller.llenarProductos(this.cbxEliminar);*/



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

				try { 
				if(controller.registrarProducto(new Entities.Producto(this.txtCodigo.Text, this.txtDescripcion.Text, Convert.ToDouble(this.txtValor.Text), Convert.ToInt32(this.txtCantidad.Text))))
				{
					MessageBox.Show("Producto Registrado");
					limpiar();
					actualizarTablas();
					actualizarCbx();
				}
				else
				{
					MessageBox.Show("Error al registrar producto");
				
				}
				}catch(Exception ex)
				{
					MessageBox.Show("Ingrese los valores adecuados");
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

		//-----
		private void gridModificarProd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			String valor = this.gridModificarProd.CurrentCell.Value.ToString();

			Entities.Producto prod = controller.llenarObjProduct(valor);

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

		private void cbxUpdateProd_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}

		private void btnBuscarUpdate_Click(object sender, EventArgs e)
		{
			Entities.Producto prod = (Entities.Producto)this.cbxUpdateProd.SelectedItem;

			if (prod.Descripcion == "Todos")
			{
				this.gridModificarProd.DataSource = controller.llenarProdutosGrid();
			}
			else
			{
				this.gridModificarProd.DataSource = controller.llenarProductosGrid(prod);
			}

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			String cod = this.txtUpdCodigo.Text;
			String des = this.txtUpdDescripcion.Text;
			double val = Convert.ToDouble(this.txtUpdValor.Text);
			int can = Convert.ToInt32(this.txtUpdCantidad.Text);

			Entities.Producto prodUp = new Entities.Producto(cod, des, val, can);

			if (controller.actualizarProd(prodUp))
			{
				MessageBox.Show("Producto Actualizado");
				limpiarUPdate();
				actualizarTablas();
				actualizarCbx();

			}
			else
			{
				MessageBox.Show("Error al actualizar el producto");
			}
		}

		public void limpiarUPdate()
		{
			this.txtUpdCantidad.Clear();
			this.txtUpdCodigo.Clear();
			this.txtUpdDescripcion.Clear();
			this.txtUpdValor.Clear();
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cbxEliminar_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnBuscarEliminar_Click(object sender, EventArgs e)
		{
			Entities.Producto prod = (Entities.Producto)this.cbxEliminar.SelectedItem;

			if(prod.Descripcion == "Todos")
			{
				this.gridEliminar.DataSource = controller.llenarProdutosGrid();
			}
			else
			{
				this.gridEliminar.DataSource = controller.llenarProductosGrid(prod);
			}
		}

		private void gridEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			String valor = this.gridEliminar.CurrentCell.Value.ToString();

			Entities.Producto prod = controller.llenarObjProduct(valor);

			try
			{
				this.txtDeleteCod.Text = prod.Codigo;
				this.txtDeleteNom.Text = prod.Descripcion;
			}catch(Exception ex)
			{
				MessageBox.Show("Seleccione el código del producto");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Entities.Producto prod = new Entities.Producto();
			prod.Codigo = this.txtDeleteCod.Text;
			

			if (controller.eliminarProd(prod))
			{
				MessageBox.Show("Producto eliminado");
				limpiarEliminar();
				actualizarTablas();
				actualizarCbx();
				//this.cbxEliminar = controller.llenarProductos(this.cbxEliminar);

			}
			else
			{
				MessageBox.Show("Error al eliminar producto");
			}
		}

		private void limpiarEliminar()
		{
			this.txtDeleteNom.Clear();
			this.txtDeleteCod.Clear();
		}

		private void actualizarTablas()
		{



			DataTable tabla = controller.llenarProdutosGrid();
			this.gridTabla.DataSource = tabla;
			this.gridModificarProd.DataSource = controller.llenarProdutosGrid();
			this.gridEliminar.DataSource = controller.llenarProdutosGrid();
		}

		private void actualizarCbx()
		{
			this.cbxProductos.DataSource = controller.llenarCbx();
			this.cbxUpdateProd.DataSource = controller.llenarCbx();
			this.cbxEliminar.DataSource = controller.llenarCbx();
		}
	}


}
