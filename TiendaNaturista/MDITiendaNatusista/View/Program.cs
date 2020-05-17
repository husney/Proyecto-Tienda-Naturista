using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITiendaNatusista
{
	 class Program
	{
		
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Login l = new Login();
			l.Show();
			Application.Run();


		}
		
	}
}
