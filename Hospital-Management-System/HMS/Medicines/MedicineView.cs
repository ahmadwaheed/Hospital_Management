using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Medicines
{
    public partial class MedicineView : Form
    {
        public MedicineView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            addMedicine.ShowDialog();
        }
    }
}
