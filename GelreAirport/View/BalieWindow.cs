using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelreAirport
{
    public partial class BalieWindow : Form
    {
        public BalieWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lbBalies.Items.Add("Balie A");
            lbBalies.Items.Add("Balie B");
            lbBalies.Items.Add("Balie C");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lbBalies.SelectedIndex >= 0)
            {
                this.Hide();
                ZoekenPassagierWindow window = new ZoekenPassagierWindow();
                window.Show();
            }
            else
            {
                MessageBox.Show("Selecteer aub een balie.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
    }
}
