﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void btnExploreNow_Click(object sender, EventArgs e)
        {
            ExplorerNow objExplorerNow = new ExplorerNow();
            objExplorerNow.Show();
            this.Hide();
            
        }
    }
}
