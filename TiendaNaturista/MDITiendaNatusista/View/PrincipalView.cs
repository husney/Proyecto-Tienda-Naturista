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
	}
}
