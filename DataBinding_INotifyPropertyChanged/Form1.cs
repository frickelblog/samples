using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBinding_INotifyPropertyChanged
{
    public partial class Form1 : Form
	{
		DatenKlasse DatenObjekt;

		public Form1()
		{
			InitializeComponent();
			DatenObjekt = new DatenKlasse();
		}

		// Load der Form - Hinzufügen des DataBinding
		private void Form1_Load(object sender, EventArgs e)
		{
			label1.DataBindings.Add("Text", DatenObjekt, "DatenString");
			//-----------------------------------------------------------------------------
			// Binden der ComboBox an die Liste des DatenObjektes
			comboBox1.DataBindings.Add("DataSource", DatenObjekt, "DatenListe");
			comboBox1.ValueMember = "ListenString1";
			comboBox1.DisplayMember = "ListenString2";
			//-----------------------------------------------------------------------------
		}

		// Click-Event des Button1 - Neusetzen der Eigenschaft im DatenObjekt
		private void button1_Click(object sender, EventArgs e)
		{
			DatenObjekt.DatenString = "Test2";
			//-----------------------------------------------------------------------------
			// Erstellen einer Neuen Liste für das DatenObjekt
			List<ListenElement> datenliste = new List<ListenElement>();
			datenliste.Add(new ListenElement { ListenString1 = "string11", ListenString2 = "string22" });
			datenliste.Add(new ListenElement { ListenString1 = "string33", ListenString2 = "string44" });
			DatenObjekt.DatenListe = datenliste;
			// JETZT ist die ComboBox mit Aktualisiert :-)
			//-----------------------------------------------------------------------------
		}
	}

	// Die Test-Datenklasse
	public class DatenKlasse : INotifyPropertyChanged
	{
		private string _DatenString;
		public string DatenString
		{
			get { return _DatenString; }
			set
			{
				_DatenString = value;
				NotifyPropertyChanged("DatenString");
			}
		}

		// ----------------------------------------------
		// Liste für die Combo-Box
		private List<ListenElement> _DatenListe;
		public List<ListenElement> DatenListe
		{
			get { return _DatenListe; }
			set
			{
				_DatenListe = value;
				NotifyPropertyChanged("DatenListe");
			}
		}
		//-----------------------------------------------

		public DatenKlasse()
		{
			_DatenString = "Test";
			//------------------------------------------------------------------------------------------
			// Erzeugen der Liste mit ListenElementen für die Combo-Box
			_DatenListe = new List<ListenElement>();
			_DatenListe.Add(new ListenElement { ListenString1 = "string1", ListenString2 = "string2" });
			_DatenListe.Add(new ListenElement { ListenString1 = "string3", ListenString2 = "string4" });
			//------------------------------------------------------------------------------------------
		}

		#region ---- INotifyPropertyChanged Implementierung ----
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged(String info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
		#endregion
	}

	public class ListenElement
	{
		public string ListenString1 { get; set; }
		public string ListenString2 { get; set; }
	}
}
