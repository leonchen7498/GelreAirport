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

                            using (var command = new SqlCommand())
                            {
                                
                                command.Connection = _db.GetConnection();
                                command.CommandText =
                                    $@"SELECT * FROM Passagier WHERE naam LIKE '%{zoekTerm.Text}%'";
                                command.CommandType = CommandType.Text;

                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        var passagier = new Passagier(
                                            Convert.ToInt32(reader["passagiernummer"]),
                                            Convert.ToString(reader["naam"]),
                                            Convert.ToChar(reader["geslacht"]),
                                            Convert.ToDateTime(reader["geboortedatum"]));
                                        lbPassagiers.Items.Add(passagier);
                                    }
                                }
                            }
                        }
                        break;

                    case "Vluchtnummer":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.Parameters.AddWithValue("@zoekTerm", zoekTerm.Text);
                                command.CommandText =
                                    $@"SELECT P.* FROM Passagier AS P INNER JOIN PassagierVoorVlucht PV ON 
                                    P.passagiernummer = PV.passagiernummer
                                    WHERE PV.vluchtnummer = {zoekTerm.Text}";
                                command.CommandType = CommandType.Text;

                                using (var reader = command.ExecuteReader())
                                {

                                    while (reader.Read())
                                    {
                                        var passagier = new Passagier(Convert.ToInt32(reader["passagiernummer"]),
                                            Convert.ToString(reader["naam"]),
                                            Convert.ToChar(reader["geslacht"]),
                                            Convert.ToDateTime(reader["geboortedatum"]));
                                        lbPassagiers.Items.Add(passagier);
                                    }
                                }
                            }
                        }
                        break;
                    case "Bestemming":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.CommandText =
                                    $@"  SELECT p.* FROM Passagier p
                                INNER JOIN PassagierVoorVlucht pv ON pv.passagiernummer = p.passagiernummer
                                INNER JOIN Vlucht v ON v.vluchtnummer = pv.vluchtnummer
                                INNER JOIN Luchthaven l ON l.luchthavencode = v.luchthavencode
                                WHERE l.land LIKE '%{zoekTerm.Text}%'";
                                command.CommandType = CommandType.Text;

                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        var passagier = new Passagier(
                                            Convert.ToInt32(reader["passagiernummer"]),
                                            Convert.ToString(reader["naam"]),
                                            Convert.ToChar(reader["geslacht"]),
                                            Convert.ToDateTime(reader["geboortedatum"]));
                                        lbPassagiers.Items.Add(passagier);
                                    }
                                }
                            }
                        }
                        break;
                    case "Maatschappij":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.CommandText =
                                    $@"  SELECT p.* FROM Passagier p
                                INNER JOIN PassagierVoorVlucht pv ON pv.passagiernummer = p.passagiernummer
                                INNER JOIN Vlucht v ON v.vluchtnummer = pv.vluchtnummer
                                INNER JOIN Maatschappij m ON m.maatschappijcode = v.maatschappijcode
                                WHERE m.naam LIKE '%{zoekTerm.Text}%'";
                                command.CommandType = CommandType.Text;

                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        var passagier = new Passagier(
                                            Convert.ToInt32(reader["passagiernummer"]),
                                            Convert.ToString(reader["naam"]),
                                            Convert.ToChar(reader["geslacht"]),
                                            Convert.ToDateTime(reader["geboortedatum"]));
                                        lbPassagiers.Items.Add(passagier);
                                    }
                                }
                            }
                        }
                        break;
                    case "Vertrekdatum":
                        using (_db.GetConnection())
                        {
                            _db.GetConnection().Open();

                            using (var command = new SqlCommand())
                            {
                                command.Connection = _db.GetConnection();
                                command.Parameters.AddWithValue("@zoekTerm", zoekTerm.Text);
                                command.CommandText =
                                    $@"SELECT P.* FROM Passagier AS P 
                                INNER JOIN PassagierVoorVlucht PV ON P.passagiernummer = PV.passagiernummer
                                INNER JOIN Vlucht v ON v.vluchtnummer = PV.vluchtnummer
                                    WHERE CONVERT(VARCHAR(50), v.vertrektijdstip, 121) LIKE '{zoekTerm.Text}%'";
                                command.CommandType = CommandType.Text;

                                using (var reader = command.ExecuteReader())
                                {

                                    while (reader.Read())
                                    {
                                        var passagier = new Passagier(Convert.ToInt32(reader["passagiernummer"]),
                                            Convert.ToString(reader["naam"]),
                                            Convert.ToChar(reader["geslacht"]),
                                            Convert.ToDateTime(reader["geboortedatum"]));
                                        lbPassagiers.Items.Add(passagier);
                                    }
                                }
                            }
                        }
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

            var window = new DetailedPassagierVluchtWindow((Passagier)lbPassagiers.SelectedItem, _balie);
            window.Show();
        }

        private void ZoekenPassagierWindow_Load(object sender, EventArgs e)
        {
            zoekOptie.SelectedIndex = 0;
        }
    }
}
