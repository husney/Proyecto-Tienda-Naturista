﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITiendaNatusista
{
	public partial class PrincipalView : Form
	{
		public PrincipalView()
		{
			
			InitializeComponent();
		

		}

		private void PrincipalView_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void PrincipalView_Load(object sender, EventArgs e)
		{
			
		}

		private void menuPrincipal_Opening(object sender, CancelEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void productosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.Productos p = new View.Productos();
			p.Show();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.Inventario invent = new View.Inventario();
			invent.Show();
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.Cliente cli = new View.Cliente();
			cli.Show();
		}

		private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.Facturar fac = new View.Facturar();
			fac.Show();
		}

		

		

		private void txtPrueba_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
