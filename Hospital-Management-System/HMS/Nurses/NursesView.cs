using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Nurses
{
    public partial class NursesView : Form
    {
        public NursesView()
        {
            InitializeComponent();
        }

        private void NursesView_Load(object sender, EventArgs e)
        {
            dropdown1.SelectedItem = "--Select--";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNurse addNurse = new AddNurse();
            addNurse.ShowDialog();
        }
    }
}
