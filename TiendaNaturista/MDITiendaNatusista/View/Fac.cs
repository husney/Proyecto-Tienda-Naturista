﻿using System;
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
	public partial class Factura : Form
	{
		public Factura()
		{
			InitializeComponent();
		}

		private void Fac_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
		}
	}
}
