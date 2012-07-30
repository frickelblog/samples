using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreadTest
{
	public partial class Form1 : Form
	{
		private FakeThread ft;

		public Form1()
		{
			InitializeComponent();
			ft = new FakeThread();
			ft.Event_OnFakeThread += new OnFakeThreadHandler(OnFakeThread);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Threading.Thread t = new System.Threading.Thread(ft.test);
			t.Start();
		}
		
		private void OnFakeThread()
		{
			if (this.InvokeRequired)
			{
				// Wenn Invoke nötig ist, ...
				// dann rufen wir die Methode selbst per Invoke auf
				this.Invoke(new OnFakeThreadHandler(OnFakeThread));
				return;
			}

			textBox1.Text = textBox1.Text + DateTime.Now.ToString() + Environment.NewLine;
		}
	}
}
