﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBakery.LogicLayer;

namespace TheBakery
{
    public partial class TheBakery : Form
    {
        public TheBakery()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getProducts(string categoryName)
        {
            Logic logic = new Logic();

        }
    }
}
