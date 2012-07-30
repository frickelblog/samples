using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listviewtest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			//listView1 anpassen - Eine Liste mit Einer Spalte
			listView1.View = View.Details;
			listView1.Columns.Add(new ColumnHeader());
			listView1.Columns[0].Text = "Items";
			listView1.Columns[0].Width = listView1.Width;

			//listView2 anpassen - Eine Liste mit einer Spalte, aber Bunt :-)
			listView2.View = View.Details;
			listView2.Columns.Add(new ColumnHeader());
			listView2.Columns[0].Text = "Items";
			listView2.Columns[0].Width = listView2.Width;

			//listView3 anpassen - Eine Liste mit mehreren Spalten :-)
			listView3.View = View.Details;
			listView3.Columns.Add(new ColumnHeader());
			listView3.Columns[0].Text = "Items";
			listView3.Columns[0].Width = listView3.Width / 3;
			listView3.Columns.Add(new ColumnHeader());
			listView3.Columns[1].Text = "mehr Items";
			listView3.Columns[1].Width = listView3.Width / 3;
			listView3.Columns.Add(new ColumnHeader());
			listView3.Columns[2].Text = "andere Items";
			listView3.Columns[2].Width = listView3.Width / 3;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listView1.Items.Add(new ListViewItem("Neues Item"));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = new ListViewItem();
			lvi.BackColor = Color.LightSeaGreen;
			lvi.ForeColor = Color.Blue;
			lvi.Text = "Buntes Item";

			listView2.Items.Add(lvi);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = new ListViewItem("Item");	// Normales Item ohne Formatierung
			lvi.UseItemStyleForSubItems = false;			// Default Style NICHT für SubItems verwenden!

			// Ein Buntes Item hinzufügen
			ListViewItem.ListViewSubItem lviSub1 = new ListViewItem.ListViewSubItem();
			lviSub1.BackColor = Color.LightSeaGreen;
			lviSub1.ForeColor = Color.Blue;
			lviSub1.Text = "Buntes Item";
			lvi.SubItems.Add(lviSub1);						// Subitem dem Item hinzufügen
						
			ListViewItem.ListViewSubItem lviSub2 = new ListViewItem.ListViewSubItem();
			lviSub2.BackColor = Color.LightPink;
			lviSub2.ForeColor = Color.Gray;
			lviSub2.Text = "Anderes SubItem";
			lvi.SubItems.Add(lviSub2);						// Subitem dem Item hinzufügen
			
			listView3.Items.Add(lvi);						// Item dem Listview Hinzufügen


		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			Console.WriteLine(listView1.SelectedItems[0].Text);
		}

		private void listView2_MouseClick(object sender, MouseEventArgs e)
		{
			Console.WriteLine(listView2.SelectedItems[0].Text);
		}

		private void listView3_MouseClick(object sender, MouseEventArgs e)
		{
			Console.WriteLine(listView3.SelectedItems[0].Text);
		}
	}
}
