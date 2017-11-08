using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelreAirport.View
{
    public partial class VoegBagageToeDialog : Form
    {
        public int Gewicht = 0;
        public int Vluchtnummer = 0;

        public VoegBagageToeDialog(int vluchtnummer)
        {
            InitializeComponent();
            this.Vluchtnummer = vluchtnummer;
        }

        private void opslaanBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.gewichtTextBox.Text, out var value))
            {
                this.Gewicht = value;
            }
            else
            {
                MessageBox.Show(@"Rond het gewicht af a.u.b.", @"Incorrect gewicht", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
