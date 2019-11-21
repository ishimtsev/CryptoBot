using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoBot
{
	public partial class APIkeys : Form
	{
		public APIkeys()
		{
			InitializeComponent();
			OKbutton.Enabled = false;
		}

		private void OKbutton_Click(object sender, EventArgs e)
		{
			Request.PublicAPIkey = textBox1.Text;
			Request.SecretAPIkey = textBox2.Text;
			DialogResult = DialogResult.OK;
		}

		private void TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
				OKbutton.Enabled = true;
			else
				OKbutton.Enabled = false;
		}
	}
}
