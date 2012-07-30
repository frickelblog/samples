using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JsonGeneric
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			data DatenObj = new data();
			DatenObj.Name = "Sven Schmalle";
			DatenObj.Birth = new DateTime(1983, 05, 08);
			DatenObj.Deleted = false;

			string JSONString = Classes.JSON.JSONSerialize<data>(DatenObj);
			textBox1.Text = JSONString;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			data DatenObj = Classes.JSON.JSONDeserialise<data>(textBox1.Text);
			propertyGrid1.SelectedObject = DatenObj;
		}
	}
}
