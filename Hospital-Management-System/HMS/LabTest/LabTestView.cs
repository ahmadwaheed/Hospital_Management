using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.LabTest
{
    public partial class LabTestView : Form
    {
        public LabTestView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLabTest addLabTest=new AddLabTest();
            addLabTest.ShowDialog();
        }
    }
}
