﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BedCategories
{
    public partial class BedCategoriesView : Form
    {
        public BedCategoriesView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBedCategories addBedCategories = new AddBedCategories();
            addBedCategories.ShowDialog();
        }
    }
}
