using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keymaster
{
	public partial class formMain : Form
	{


		public formMain()
		{
			InitializeComponent();
		}

		private void formMain_Load(object sender, EventArgs e)
		{
			//Load from file

			//Populate lists
		}

		private void buttonAddSerial_Click(object sender, EventArgs e)
		{
			formAddSerial addSerial = new formAddSerial();
			addSerial.Show();
		}
	}
}
