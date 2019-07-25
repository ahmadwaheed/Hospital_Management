using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BedAllotments
{
    public partial class BedAllotmentsView : Form
    {
        public BedAllotmentsView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBedAllotments addBedAllotments = new AddBedAllotments();
            addBedAllotments.ShowDialog();
        }
    }
}
