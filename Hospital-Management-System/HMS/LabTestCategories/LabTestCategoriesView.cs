using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.LabTestCategories
{
    public partial class LabTestCategoriesView : Form
    {
        public LabTestCategoriesView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLabTestCategory addLabTestCategory = new AddLabTestCategory();
            addLabTestCategory.ShowDialog();
        }
    }
}
