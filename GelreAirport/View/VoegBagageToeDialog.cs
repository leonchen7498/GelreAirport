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
        public string Gewicht = null;

        public VoegBagageToeDialog()
        {
            InitializeComponent();
        }

        private void opslaanBtn_Click(object sender, EventArgs e)
        {
            this.Gewicht = this.gewichtTextBox.Text;
        }
    }
}
