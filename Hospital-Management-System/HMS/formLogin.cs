using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class formLogin : Form
    {

        public formLogin()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HMS.Layout lay = new Layout();
            this.Hide();
            lay.Show();
        }
    }
}
