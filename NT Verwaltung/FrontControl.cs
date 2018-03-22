using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT_Verwaltung
{
    public partial class FrontControl : Form
    {
        public FrontControl()
        {
            InitializeComponent();
        }

        private void btnOpenVerwaltung_Click(object sender, EventArgs e)
        {
            var Verwaltung = new FormMain();
            Verwaltung.Show();
            this.Hide();
        }
    }
}
