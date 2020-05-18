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
	public partial class Cliente : Form
	{
		private Bussines.Controlador controller;

		public Cliente()
		{
			InitializeComponent();
			controller = new Bussines.Controlador();
			actualizarGrid();
			llenarCBXOp();




		}

		private void btnNuevoCli_Click(object sender, EventArgs e)
		{
			limpiar();
		}
		
		private void btnGuardarCli_Click(object sender, EventArgs e)
		{
			if(this.txtCorreoCli.Text == "" && this.txtDireccionCli.Text =="" && this.txtDocumentoCli.Text == "" && this.txtNombreCli.Text == "" && this.txtTelefonoCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese los valores correspondientes");
			}
			else if (this.txtDocumentoCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese el documento");
			}
			else if (this.txtNombreCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese el nombre");
			}else if(this.txtDireccionCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese la dirección");
			}else if(this.txtTelefonoCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese el telefono");
			}
			else if (this.txtCorreoCli.Text == "")
			{
				MessageBox.Show("Por favor ingrese el correo");
			}
			else
			{
				String doc = this.txtDocumentoCli.Text;
				String nom = this.txtNombreCli.Text;
				String dir = this.txtDireccionCli.Text;
				String tel = this.txtTelefonoCli.Text;
				String cor = this.txtCorreoCli.Text;
				MessageBox.Show(doc + nom + dir + tel + cor);

				if (controller.registrarCliente(new Entities.Cliente(doc, nom, dir, tel, cor)))
				{
					MessageBox.Show("Cliente registrado");
					limpiar();
					actualizarGrid();
				}
				else
				{
					MessageBox.Show("Error al registrar");
				}
			}


		}

		private void limpiar()
		{
			this.txtDocumentoCli.Clear();
			this.txtNombreCli.Clear();
			this.txtDireccionCli.Clear();
			this.txtTelefonoCli.Clear();
			this.txtCorreoCli.Clear();
		}

		private void Cliente_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
		}

		private void tabPage2_Click(object sender, EventArgs e)
		{
			
		}

		private void actualizarGrid()
		{
			this.gridTablaCli.DataSource = controller.agregarClientes("",0);
			this.gridCliUp.DataSource = controller.agregarClientes("", 0);
			this.gridElimCli.DataSource = controller.agregarClientes("", 0);
		}

		private void btnBuscarCli_Click(object sender, EventArgs e)
		{

			
			

			if(this.txtBuscDocCli.Text == "")
			{
				actualizarGrid();
			}
			else
			{
				String opt = this.cbxOpC.SelectedItem.ToString();
				int op = 0;
				if(opt == "Documento")
				{
					op = 1;
				}else if(opt == "Número")
				{
					op = 2;
				}else if(opt == "Nombre")
				{
					op = 3;
				}else if( opt == "Dirección")
				{
					op = 4;
				}else if(opt == "Telefono")
				{
					op = 5;
				}else if(opt == "Correo")
				{
					op = 6;
				}

				String val = this.txtBuscDocCli.Text;
				this.gridTablaCli.DataSource = controller.agregarClientes(val, op);

			}


		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void Cliente_Load(object sender, EventArgs e)
		{

		}

		private void llenarCBXOp()
		{

			List<String> opciones = new List<string>();
			opciones.Add("Documento");
			opciones.Add("Número");
			opciones.Add("Nombre");
			opciones.Add("Dirección");
			opciones.Add("Telefono");
			opciones.Add("Correo");

			this.cbxOpC.DataSource = opciones;

		}

		private void cbxOpC_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void gridCliUp_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			String val = gridCliUp.CurrentCell.Value.ToString();

			Entities.Cliente cli = controller.agregarObjetoCliente(val);
			try
			{
				this.txtNumUp.Text = Convert.ToString(cli.Numero);
				this.txtDocUp.Text = cli.Documento;
				this.txtNomUp.Text = cli.Nombre;
				this.txtTelUp.Text = cli.Telefono;
				this.txtDirUp.Text = cli.Direccion;
				this.txtCorUp.Text = cli.Correo;
			}catch(Exception ex)
			{
				MessageBox.Show("Seleccione el número del cliente");
			}
				
		}

		private void gridCliUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.txtNumUp.Text);
			String doc = this.txtDocUp.Text;
			String nom = this.txtNomUp.Text;
			String dir = this.txtDirUp.Text;
			String tel = this.txtTelUp.Text;
			String cor = this.txtCorUp.Text;

			if(controller.actualizarCliente(new Entities.Cliente(num, doc, nom, dir, tel, cor)))
			{
				MessageBox.Show("Cliente actualizado");
				limpiarCliUP();
				actualizarGrid();
			}
			else
			{
				MessageBox.Show("Error al actualizar cliente");
			}


		}

		public void limpiarCliUP()
		{
			this.txtNumUp.Clear();
			this.txtDocUp.Clear();
			this.txtNomUp.Clear();
			this.txtDirUp.Clear();
			this.txtTelUp.Clear();
			this.txtCorUp.Clear();
		}

		private void tabPage4_Click(object sender, EventArgs e)
		{

		}

		private void gridElimCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void gridElimCli_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			String val = gridElimCli.CurrentCell.Value.ToString();
			
			Entities.Cliente cliente = controller.agregarObjetoCliente(val);

			try
			{
				this.txtNomDel.Text = cliente.Nombre;
				this.txtDocDel.Text = cliente.Documento;
				this.txtNumeroDel.Text = Convert.ToString(cliente.Numero);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Seleccione el número del cliente");
			}
		}

		private void btnDeleteCli_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(this.txtNumeroDel.Text);
			
			Entities.Cliente cli = new Entities.Cliente();
			cli.Numero = n;

			if (controller.eliminarCliente(cli))
			{
				MessageBox.Show("Cliente Eliminado");
				limiparDel();
				actualizarGrid();

			}
			else
			{
				MessageBox.Show("Error al eliminar cliente");
			}
			
		}

		public void limiparDel()
		{
			this.txtDocDel.Clear();
			this.txtNomDel.Clear();
			this.txtNumeroDel.Clear();
		}
	}

}
