using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void toevoegenBagageBtn_Click(object sender, EventArgs e)
        {
            var dlg = new VoegBagageToeDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;
            var result = dlg.Gewicht;
            MessageBox.Show(result);
        }

        private void verwijderenBagageBtn_Click(object sender, EventArgs e)
        {
            if (bagageDataGrid.SelectedRows.Count <= 0) return;

            var msgBox = MessageBox.Show(@"Weet u het zeker?", @"Bagage verwijderen.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (msgBox)
            {
                case DialogResult.Yes:
                    MessageBox.Show(@"Ok");
                    break;
                case DialogResult.No:
                    MessageBox.Show(@"Not ok");
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void opslaanBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
