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
	public partial class Facturar : Form
	{
		Bussines.Controlador controller;
		public Facturar()
		{
			
			InitializeComponent();
			controller = new Bussines.Controlador();
			llenarCbx();
			this.txtValTotal.Text = null;
			this.txtValProd.Text = null;
			


		}

		private void cbxOpC_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Entities.Producto b = (Entities.Producto) this.cbxFacProd.SelectedItem;

			int cantidad = Convert.ToInt32(this.numCan.Value);

			double valP = b.Valor * cantidad;

			this.txtValProd.Text = valP.ToString();
;


		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Facturar_Load(object sender, EventArgs e)
		{

		}

		public void llenarCbx()
		{
			this.cbxFacProd.DataSource = controller.llenarCbxFac();
			this.cbxCliFac.DataSource = controller.llenarCbxCliente();
			this.cbxFacVen.DataSource = controller.cbxVendedores();
		}

		private void Facturar_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
		}

		private void cbxFacProd_SelectedIndexChanged(object sender, EventArgs e)
		{
			Entities.Producto prod = (Entities.Producto)this.cbxFacProd.SelectedItem;

			this.txtValUnit.Text = prod.Valor.ToString();
		}

		private void txtValProd_TextChanged(object sender, EventArgs e)
		{

		}

		double sum = 0;
		private void btnAgregarFac_Click(object sender, EventArgs e)
		{
			Entities.Producto p = (Entities.Producto)this.cbxFacProd.SelectedItem;
			if(p.Cantidad > 0) { 
			Entities.Cliente c = (Entities.Cliente) this.cbxCliFac.SelectedItem;
			Entities.Vendedor ve = (Entities.Vendedor)this.cbxFacVen.SelectedItem;
			int cant = Convert.ToInt32(this.numCan.Value);



			
			if (ve.User == "Seleccione el vendedor")
			{
				MessageBox.Show("Seleccione el vendedor");
			}
			else { 
			if(this.numCan.Value != 0)
				{
					
					if (controller.registrarFactura(p, c, ve, cant))
					{
						MessageBox.Show("Produto Registrado");
						double valT = Convert.ToDouble(this.txtValProd.Text);
						this.gridFactura.DataSource = controller.gridFacturando();
						sum = sum + (Convert.ToDouble(this.txtValProd.Text));
						this.txtValTotal.Text = sum.ToString();

					}
					else
					{
						MessageBox.Show("Error al registrar producto");
					}
				}
			}
			}



		}

		private void gridFacturando_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void gridFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			try { 
				double total = Convert.ToDouble(this.txtValTotal.Text);

				if (controller.realizarVenta(total))
				{
					MessageBox.Show("Venta relizada");
					this.gridFactura.DataSource = null;
					this.txtValTotal.Text = null;
					this.txtValProd.Text = null;
					this.numCan.Value = 0;
					mostrarFactura();

				}
				else
				{
					MessageBox.Show("Error en la venta");
				}
			}catch(Exception ex)
			{
				MessageBox.Show("Agrege los productos que se venderan");
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		private void mostrarFactura()
		{
			Entities.Factura fac = controller.mostrarFactura();

			View.Fac f = new View.Fac();
			f.facNumero.Text = fac.Numero.ToString();
			f.facFecha.Text = fac.Fecha;
			f.facCliente.Text = fac.Cliente;
			f.facVendedor.Text = fac.Vendedor;
			f.facTotal.Text = fac.ValorTotal.ToString();
			f.gridFactura.DataSource = controller.productosFactura();
			f.Show();


			
		}
	}
}
