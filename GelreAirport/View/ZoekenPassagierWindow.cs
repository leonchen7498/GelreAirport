using System;
using System.Windows.Forms;
using GelreAirport.Model;

namespace GelreAirport.View
{
    public partial class ZoekenPassagierWindow : Form
    {
        private readonly Balie _balie;

        public ZoekenPassagierWindow(Balie balie)
        {
            InitializeComponent();
            this._balie = balie;
            MessageBox.Show($@"Balie {this._balie.Balienummer}");
        }

        private void ZoekenPassagierWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ZoekenPassagierWindow_Load(object sender, System.EventArgs e)
        {
            var pass1 = new Passagier(1, "Leon Chen", 'F', DateTime.Now);
            var pass2 = new Passagier(2, "Ugur Ekim", 'M', DateTime.Now);

            lbPassagiers.Items.Add(pass1);
            lbPassagiers.Items.Add(pass2);
        }

        private void openBtn_Click(object sender, System.EventArgs e)
        {
            if (lbPassagiers.SelectedIndex >= 0)
            {
                this.Hide();
                var window =
                    new DetailedPassagierVluchtWindow((Passagier) lbPassagiers.SelectedItem);
                window.Show();
            }
        }
    }
}
