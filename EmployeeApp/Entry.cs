﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
