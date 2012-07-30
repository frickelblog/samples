using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BildDownload
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Funktionen.GetImageFromURL(txt_url.Text);
		}

		private void btn_speichern_Click(object sender, EventArgs e)
		{
			pictureBox1.Image.Save("c:\\test.png", System.Drawing.Imaging.ImageFormat.Png);
		}
	}
}
