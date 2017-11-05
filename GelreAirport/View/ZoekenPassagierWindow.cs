using System.Windows.Forms;
using GelreAirport.Model;

namespace GelreAirport.View
{
    public partial class ZoekenPassagierWindow : Form
    {
        private Balie _balie;

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

        }
    }
}
