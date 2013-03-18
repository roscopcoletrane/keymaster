using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace keymaster
{
	public partial class formMain : Form
	{
		XmlDocument dbXML;

		public formMain()
		{
			InitializeComponent();
		}

		private void formMain_Load(object sender, EventArgs e)
		{
			//Load from file
			dbXML = new XmlDocument();
			dbXML.Load("db.xml");


			//Populate lists
			string product;
			string version;
			foreach (XmlNode node in dbXML["Database"].ChildNodes)
			{
				product = node["Product"].InnerText.ToString();
				version = node["Version"].InnerText.ToString();
				listBoxProgram.Items.Add(product + " - " + version);
			}
		}

		private void buttonAddSerial_Click(object sender, EventArgs e)
		{
			formAddSerial addSerial = new formAddSerial();
			addSerial.Show();
		}
	}
}
