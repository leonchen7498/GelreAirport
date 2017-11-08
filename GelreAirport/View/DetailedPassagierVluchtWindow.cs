using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GelreAirport.Controller;
using GelreAirport.Model;

namespace GelreAirport.View
{
    public partial class DetailedPassagierVluchtWindow : Form
    {
        private readonly Passagier _passagier;

        public DetailedPassagierVluchtWindow(Passagier passagier)
        {
            InitializeComponent();
            this._passagier = passagier;
        }

        private void DetailedPassagierVluchtWindow_Load(object sender, EventArgs e)
        {
            this.passagierNrTextBox.Text = this._passagier.Nummer.ToString();
            this.naamTextBox.Text = this._passagier.Naam;
            this.geslachtTextBox.Text = this._passagier.Geslacht.ToString();
            this.geboortedatumTextBox.Text = this._passagier.Geboortedatum.ToLongDateString();

            LoadAllFlights();
        }

        private void toevoegenBagageBtn_Click(object sender, EventArgs e)
        {
            if (!(lbGeboekteVluchten.SelectedItem is Vlucht selectedItem)) return;

            var dlg = new VoegBagageToeDialog(selectedItem.Vluchtnummer);

            if (dlg.ShowDialog() != DialogResult.OK) return;

            var db = new DatabaseConnection();
            try
            {
                using (db.GetConnection())
                {
                    db.GetConnection().Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = db.GetConnection();
                        command.Parameters.AddWithValue("@passagiernummer", _passagier.Nummer);
                        command.Parameters.AddWithValue("@vluchtnummer", dlg.Vluchtnummer);
                        command.Parameters.AddWithValue("@gewicht", dlg.Gewicht);
                        command.CommandText =
                            "INSERT INTO Object (passagiernummer, vluchtnummer, gewicht) VALUES (@passagiernummer, @vluchtnummer, @gewicht)";
                        command.CommandType = CommandType.Text;

                        command.ExecuteNonQuery();

                    }
                }
                LoadAllBagagesFromFlight(dlg.Vluchtnummer);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verwijderenBagageBtn_Click(object sender, EventArgs e)
        {
            if (lbIngecheckteBagage.SelectedIndex < 0) return;

            var msgBox = MessageBox.Show(@"Weet u het zeker?", @"Bagage verwijderen.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgBox != DialogResult.Yes) return;

            if (!(lbIngecheckteBagage.SelectedItem is Model.Object selectedItem)) return;


            var db = new DatabaseConnection();
            try
            {
                using (db.GetConnection())
                {
                    db.GetConnection().Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = db.GetConnection();
                        command.Parameters.AddWithValue("@passagiernummer", _passagier.Nummer);
                        command.Parameters.AddWithValue("@vluchtnummer", selectedItem.Vluchtnummer);
                        command.Parameters.AddWithValue("@volgnummer", selectedItem.Volgnummer);
                        command.CommandText =
                            "DELETE FROM Object WHERE volgnummer = @volgnummer AND passagiernummer = @passagiernummer AND vluchtnummer = @vluchtnummer";
                        command.CommandType = CommandType.Text;

                        command.ExecuteNonQuery();
                    }
                }
                LoadAllBagagesFromFlight(selectedItem.Vluchtnummer);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllFlights()
        {
            lbGeboekteVluchten.Items.Clear();
            var db = new DatabaseConnection();
            try
            {
                using (db.GetConnection())
                {
                    db.GetConnection().Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = db.GetConnection();
                        command.Parameters.AddWithValue("@Passagiernummer", _passagier.Nummer);
                        command.CommandText =
                            "SELECT * FROM PassagierVoorVlucht AS P INNER JOIN Vlucht AS V ON P.vluchtnummer = V.vluchtnummer WHERE P.passagiernummer = @Passagiernummer";
                        command.CommandType = CommandType.Text;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lbGeboekteVluchten.Items.Add(new Vlucht(
                                    Convert.ToInt32(reader["vluchtnummer"]),
                                    Convert.ToChar(reader["gatecode"]),
                                    Convert.ToString(reader["maatschappijcode"]),
                                    Convert.ToString(reader["luchthavencode"]),
                                    Convert.ToString(reader["vliegtuigType"]),
                                    Convert.ToInt32(reader["max_aantal_psgrs"]),
                                    Convert.ToInt32(reader["max_totaalgewicht"]),
                                    Convert.ToDecimal(reader["max_ppgewicht"]),
                                    Convert.ToDateTime(reader["vertrekTijdstip"]),
                                    Convert.ToDateTime(reader["aankomstTijdstip"])));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllBagagesFromFlight(int vluchtnummer)
        {
            lbIngecheckteBagage.Items.Clear();
            var db = new DatabaseConnection();

            try
            {
                using (db.GetConnection())
                {
                    db.GetConnection().Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = db.GetConnection();
                        command.Parameters.AddWithValue("@Passagiernummer", _passagier.Nummer);
                        command.Parameters.AddWithValue("@Vluchtnummer", vluchtnummer);
                        command.CommandText =
                            "SELECT * FROM Object WHERE passagiernummer = @Passagiernummer AND vluchtnummer = @Vluchtnummer";
                        command.CommandType = CommandType.Text;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lbIngecheckteBagage.Items.Add(new Model.Object(
                                    Convert.ToInt32(reader["volgnummer"]),
                                    Convert.ToInt32(reader["passagiernummer"]),
                                    Convert.ToInt32(reader["vluchtnummer"]),
                                    Convert.ToInt32(reader["gewicht"])));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbGeboekteVluchten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGeboekteVluchten.SelectedItem is Vlucht selectedItem)
                LoadAllBagagesFromFlight(selectedItem.Vluchtnummer);
        }
    }
}
