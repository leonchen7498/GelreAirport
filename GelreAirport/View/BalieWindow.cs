using System;
using System.Windows.Forms;
using GelreAirport.Controller;
using GelreAirport.Model;

namespace GelreAirport.View
{
    public partial class BalieWindow : Form
    {
        private DatabaseConnection _db;
        public BalieWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._db = new DatabaseConnection();
            this._db.GetConnection().Open();
            MessageBox.Show(_db.IsConnected() ? "Connected!" : "Not connected!");

            this.CenterToScreen();
            baliesListBox.Items.Add(new Balie(1));
            baliesListBox.Items.Add(new Balie(2));
            baliesListBox.Items.Add(new Balie(3));
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (baliesListBox.SelectedIndex >= 0)
            {
                this.Hide();
                var window = new ZoekenPassagierWindow((Balie)this.baliesListBox.SelectedItem);
                window.Show();
            }
            else
            {
                MessageBox.Show(@"Selecteer aub een balie.", @"Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
    }
}
