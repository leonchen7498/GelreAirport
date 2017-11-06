using System;
using System.Data;
using System.Data.SqlClient;
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

            using (this._db.GetConnection())
            {
                this._db.GetConnection().Open();
                SqlDataReader reader;

                using (var command = new SqlCommand())
                {
                    command.Connection = this._db.GetConnection();
                    command.CommandText = "SELECT * FROM Balie";
                    command.CommandType = CommandType.Text;

                    reader = command.ExecuteReader();
                }

                while (reader.Read())
                {
                    baliesListBox.Items.Add(new Balie((int)reader["balienummer"]));
                }
                reader.Close();
            }
        }

        private void baliesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
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
