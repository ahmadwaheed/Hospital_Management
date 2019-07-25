using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class AccountantView : Form
    {
        public AccountantView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAccountant addAccountant = new AddAccountant();
            addAccountant.ShowDialog();
        }
    }
}
