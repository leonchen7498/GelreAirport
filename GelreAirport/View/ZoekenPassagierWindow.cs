﻿using System;
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
    public partial class ZoekenPassagierWindow : Form
    {
        public ZoekenPassagierWindow()
        {
            InitializeComponent();
        }

        private void ZoekenPassagierWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
