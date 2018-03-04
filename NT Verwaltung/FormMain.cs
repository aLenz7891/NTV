using System;
using System.Drawing;
using System.IO;
using System.Timers;
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
            WriteToLog("<---> Programmstart  <--->"); // Programmstart-Meldung
            cbTable.SelectedIndexChanged += new EventHandler(Table_SIC); // Aktueller Tisch-Melder als optische Rückmeldung
			SetPictures(); // Setzt die Bilder fest, spätere Umwandlung Richtung dynamische HTML-Ansicht mit Icon-Zeichnung als SVG
            FillDataGridView(); // Befüllt die DataGridView-Ansicht als Excel-gleiche Tabelle
			AddTables(); // Befüllt ComboBox und Tabelle mit Tischen
			CurrentClock(); // Setzt die aktuelle jeweilige Uhrzeit fest, sowohl RechtsUnten als auch für dtpStartZeit (Stunde + Minuten)
			ReadOutSystemTXT(); // Liest die System.txt aus, um eine Übersicht der Spiele zu haben, aus welcher ausgesucht werden kann
		}

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteToLog("<---> Programmende  <--->");
        }

        /// <summary>
        /// Befüllt die dgvList direkt mit Spalten und setzt Weite fest
        /// </summary>
        private void FillDataGridView()
        {
            dgvList.Columns.Add("cTisch", "Tisch");
            dgvList.Columns.Add("cSystem", "System");
            dgvList.Columns.Add("cStart", "Startzeit");
            dgvList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns[0].Width = 80;
            WriteToLog("DataGridView befüllt.");
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

		private void CurrentClock()
		{
			System.Timers.Timer tTime = new System.Timers.Timer();
			tTime.Interval = 1000;
            tTime.AutoReset = true;
            tTime.Elapsed += t_Elapsed;
            tTime.Enabled = true;
            System.Timers.Timer tActualCBTime = new System.Timers.Timer();
            tActualCBTime.Interval = 6000; // 600000 = 10 Minutes
            tActualCBTime.AutoReset = true;
            tActualCBTime.Elapsed += tActualCBTime_Elapsed;
            tActualCBTime.Enabled = true;

        }

        /// <summary>
        /// Startet als Invoke aus Timer.Thread die ComboBox-Aktualisierung
        /// </summary>
        private void tActualCBTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => SetCBTimeMinutes()));
            }
        }

        /// <summary>
        /// Setzt die jeweilige aktuelle Uhrzeit der ComboBox dtpStartZeit alle 10 Minuten hoch
        /// </summary>
        private void SetCBTimeMinutes()
        {
            int iMinuteByTens = DateTime.Now.Minute;
            if (iMinuteByTens % 10 == 0) {
                dtpStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, iMinuteByTens, 0);
            }
        }

        private void t_Elapsed(object sender, EventArgs e)
		{
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => SetTime()));
            }
		}

        /// <summary>
        /// Setzt die jeweilige Uhrzeit fest, die RechtsUnten angezeigt wird
        /// </summary>
        private void SetTime()
        {
            lCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Erstellt alle notwendigen Tischnummern für die ComboBox und das DataGridView
        /// </summary>
        private void AddTables()
		{
			for (int i = 1; i < 41; i++)
			{
				string table = "Tisch " + i.ToString();
                dgvList.Rows.Add(table, String.Empty, String.Empty);
				cbTable.Items.Add(table);
			}
		}

		/// <summary>
        /// Eintragen der jeweiligen Systeme mitsamt Uhrzeit zu einer bestimmten Uhrzeit
        /// </summary>
        private void cmdRundenstart_Click(object sender, EventArgs e)
		{
            try
            {
                int iCurrentTable = cbTable.SelectedIndex;
                //if (dtpStartTime.Value !== DateTime.Now.TimeOfDay){ SCREAM! }
                dgvList.Rows[iCurrentTable].Cells[1].Value = cbSystem.Text;
                dgvList.Rows[iCurrentTable].Cells[2].Value = dtpStartTime.Text;
                WriteToLog("Runde auf Tisch " + (Convert.ToInt32(cbTable.SelectedIndex) + 1) + " - StartZeit: " + dtpStartTime.Text + " - System: " + cbSystem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Eintragen der Runde." + Environment.NewLine + "Fehler im Log dokumentiert", "M136-Fehler");
                WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);

            }
        }

        /// <summary>
        /// Schmeißt eine gewählte Zeileneingabe raus und vermerkt es entsprechend im Log
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int iCurrentTable = cbTable.SelectedIndex;
                dgvList.Rows[iCurrentTable].Cells[1].Value = String.Empty;
                dgvList.Rows[iCurrentTable].Cells[2].Value = String.Empty;
                WriteToLog("Runde auf Tisch " + (Convert.ToInt32(cbTable.SelectedIndex) + 1) + " wurde abgebrochen und aus dem Rundenlog gestrichen ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Austragen der Runde." + Environment.NewLine + "Fehler im Log dokumentiert", "M197-Fehler");
                WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);

            }

        }

        /// <summary>
        /// Bastelt aus den Informationen des Tages eine Übersicht zum späteren leichteren Einsehen
        /// </summary>
        private void btnSummarize_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToLog("Diese Zeile absichtlich sinnfrei!"); // Platzhalter bis mir einfällt, wie ich das passend bastle...txtCountings? interner System-int?
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Zusammenfassen!" + Environment.NewLine + "Fehler im Log dokumentiert", "M216-Fehler");
                WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }

        }

        public void WriteToLog(string sText)
		{
			FileStream fs = new FileStream(Application.StartupPath + "\\test.log", FileMode.Append);
			StreamWriter sw = new StreamWriter(fs);
			string time = DateTime.Now.ToShortTimeString();
			string writing = time + " " + sText;
			sw.WriteLine(writing);
			sw.Close();
		}

    }
}