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
		public Cliente()
		{
			InitializeComponent();
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
				MessageBox.Show("Registrando...");
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
	}
}
