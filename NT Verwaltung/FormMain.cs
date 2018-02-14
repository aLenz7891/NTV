using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace NT_Verwaltung
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			cbTable.SelectedIndexChanged += new EventHandler(Table_SIC);
			SetPictures();
			AddColumnHeader();
			AddTables();
			CurrentClock();
			ReadOutSystemTXT();
		}

		private void SetPictures()
		{
			pbPlan.Image = Image.FromFile("./bilder/ntPlan.png");
			pbLogo.Image = Image.FromFile("./bilder/ntLogo.png");
		}

		private void Table_SIC(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			int table = comboBox.SelectedIndex + 1;
			int[] coords = TableCords(table);
			if (coords != null || coords.Length == 0)
			{
				lblStatus.Text = "Tisch " + table + " gewählt";
				pbPlan.Image = Image.FromFile("./bilder/tisch" + table + ".png");
				//PaintDot(0, coords[0], coords[1]);
			}
			else
			{
				MessageBox.Show("Fehler beim Tisch auf Plan Zeichnen!", "M046-Fehler");
			}
		}

		private int[] TableCords(int table)
		{
			int[] cords = new int[2] {0,0};
			var lines = File.ReadAllLines(Application.StartupPath + "\\TischKoordinaten.txt");
			foreach (var line in lines)
			{
				var zeile = line.Split(new string[] { "," }, StringSplitOptions.None);
				if (Convert.ToInt32(zeile[0]) == table)
				{
					cords[0] = Convert.ToInt32(zeile[1]);
					cords[1] = Convert.ToInt32(zeile[2]);
				}
			}
			return cords;
		}

		private void ReadOutSystemTXT()
		{
			string[] inhalt = File.ReadAllLines(Application.StartupPath + "\\Systeme.txt");
			Array.Sort(inhalt);
			var source = new AutoCompleteStringCollection();
			source.AddRange(inhalt);
			cbSystem.AutoCompleteCustomSource = source;
			cbSystem.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cbSystem.Items.AddRange(inhalt);
		}

		private void PrepareBlock()
		{
			string[] inhalt = File.ReadAllLines(Application.StartupPath + "\\Systeme.txt");
			lvList.Items[cbTable.SelectedIndex].SubItems[dtpStartTime.Value.Hour - 5].Text = cbSystem.Text;
			WriteToLog("Runde auf Tisch " + cbTable.SelectedIndex + 1 + " - System: " + cbSystem.Text + " - StartZeit:" + dtpStartTime.Text);

		}

		private void CurrentClock()
		{
			Timer t = new Timer();
			t.Interval = 1000;
			t.Tick += new EventHandler(timer_Tick);
			t.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			lCurrentTime.Text = DateTime.Now.ToLongTimeString();
		}

		private void AddColumnHeader()
		{
			ColumnHeader header1;
			header1 = new ColumnHeader();
			header1.Text = "Tisch";
			header1.TextAlign = HorizontalAlignment.Center;
			header1.Width = 50;
			lvList.Columns.Add(header1);

			ColumnHeader[] liste = CreateTimeHeaders();
			foreach (ColumnHeader entry in liste)
			{
				lvList.Columns.Add(entry);
			}
		}

		private ColumnHeader[] CreateTimeHeaders()
		{
			ColumnHeader[] sammlung = new ColumnHeader[18];
			try
			{
				for (int i = 6; i < 24; i++)
				{
					ColumnHead oSpalte = new ColumnHead(i);
					sammlung[i - 6] = oSpalte.Head();
				}
			}
			catch (Exception ex)
			{
				WriteToLog(ex.Message + " " + ex.StackTrace);
			}
			return sammlung;
		}

		private void AddTables()
		{
			for (int i = 1; i < 41; i++)
			{
				string table = "Tisch " + i.ToString();
				ListViewItem item = new ListViewItem();
				item.Text = table;
				for (int y = 0; y < 18; y++)
				{
					item.SubItems.Add("");
				}
				cbTable.Items.Add(table);
				lvList.Items.Add(item);
			}
		}

		private void cmdRundenstart_Click(object sender, EventArgs e)
		{
			int dauer = Convert.ToInt32(tbLength.Text) > 18 ? 18 : Convert.ToInt32(tbLength.Text);
			try
			{
				if (lvList.Items[cbTable.SelectedIndex].SubItems[dtpStartTime.Value.Hour - 5].Text != "")
				{
					lvList.Items[cbTable.SelectedIndex].SubItems[dtpStartTime.Value.Hour - 5].Text = "";
				}

				lvList.Items[cbTable.SelectedIndex].SubItems[dtpStartTime.Value.Hour - 5].Text = "*" + cbSystem.Text; // Erster Tisch

				if ((dtpStartTime.Value.Hour + dauer) > 23)
				{
					dauer = 24 - dtpStartTime.Value.Hour;			
				}
				for (int i = 1; i < dauer; i++) // Alle Tische nach dem 1sten!
				{
						lvList.Items[cbTable.SelectedIndex].SubItems[dtpStartTime.Value.Hour - 5 + i].Text = cbSystem.Text;
				}
				WriteToLog("Runde auf Tisch " + cbTable.SelectedIndex + 1 + " - System: " + cbSystem.Text + " - StartZeit:" + dtpStartTime.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Fehler beim Eintragen der Runde." + Environment.NewLine + "Fehler im Log dokumentiert", "M136-Fehler");
				WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
			}
		}

		public void WriteToLog(string sText)
		{
			FileStream fs = new FileStream(Application.StartupPath + "\\test.log", FileMode.Append);
			StreamWriter sw = new StreamWriter(fs);
			string time = DateTime.Now.TimeOfDay.ToString();
			string writing = time + " " + sText;
			sw.WriteLine(writing);
			sw.Close();
		}

		//private void lvList_MouseDoubleClick(object sender, MouseEventArgs e)
		//{
		//	Point mousePosition = lvList.PointToClient(MousePosition);
		//	ListViewHitTestInfo hit = lvList.HitTest(mousePosition);
		//	int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
		//	MessageBox.Show(columnindex.ToString());
		//	// Use hit.Item
		//	// Use hit.SubItem
		//}
	}

	public partial struct ColumnHead
	{
		public int iNumber;

		public ColumnHead(int dtUhrzeit)
		{
			this.iNumber = dtUhrzeit;
		}

		public ColumnHeader Head()
		{
			ColumnHeader o;
			o = new ColumnHeader();
			o.Text = iNumber.ToString() + "h";
			o.TextAlign = HorizontalAlignment.Center;
			o.Width = 44;
			return o;
		}
	}
}