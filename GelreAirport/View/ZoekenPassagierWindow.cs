using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GelreAirport.Controller;
using GelreAirport.Model;

namespace GelreAirport.View
{
    public partial class ZoekenPassagierWindow : Form
    {
        private readonly Balie _balie;
        private DatabaseConnection _db;

        public ZoekenPassagierWindow(Balie balie)
        {
            InitializeComponent();
            _balie = balie;
        }

        private void ZoekenPassagierWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zoekenBtn_Click(object sender, EventArgs e)
        {
            lbPassagiers.Items.Clear();
            if (zoekOptie.SelectedIndex < 0 || zoekTerm == null) return;

            _db = new DatabaseConnection();
            try
            {
                switch (zoekOptie.SelectedItem.ToString())
                {
                    case "Passagiersnaam":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();
                            SqlDataReader reader;

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.CommandText =
                                    $@"SELECT * FROM Passagier WHERE naam LIKE '%{zoekTerm.Text}%'";
                                command.CommandType = CommandType.Text;

                                reader = command.ExecuteReader();
                            }

                            while (reader.Read())
                            {
                                var passagier = new Passagier(Convert.ToInt32(reader["passagiernummer"]),
                                    Convert.ToString(reader["naam"]),
                                    Convert.ToChar(reader["geslacht"]),
                                    Convert.ToDateTime(reader["geboortedatum"]));
                                lbPassagiers.Items.Add(passagier);
                            }
                            reader.Close();
                        }
                        break;

                    case "Vluchtnummer":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();
                            SqlDataReader reader;

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.CommandText =
                                    $@"SELECT P.passagiernummer, P.naam, P.geslacht, P.geboortedatum FROM Passagier AS P INNER JOIN PassagierVoorVlucht PV ON P.passagiernummer = PV.passagiernummer
    WHERE PV.vluchtnummer = '{zoekTerm.Text}'";
                                command.CommandType = CommandType.Text;

                                reader = command.ExecuteReader();
                            }

                            while (reader.Read())
                            {
                                var passagier = new Passagier(Convert.ToInt32(reader["passagiernummer"]),
                                    Convert.ToString(reader["naam"]),
                                    Convert.ToChar(reader["geslacht"]),
                                    Convert.ToDateTime(reader["geboortedatum"]));
                                lbPassagiers.Items.Add(passagier);
                            }
                            reader.Close();
                        }
                        break;
                    case "Bestemming":
                        break;
                    case "Maatschappij":
                        break;
                    case "Vertrekdatum":
                        break;
                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbPassagiers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbPassagiers.SelectedIndex < 0) return;

            var window = new DetailedPassagierVluchtWindow((Passagier)lbPassagiers.SelectedItem);
            window.Show();
        }
    }
}
