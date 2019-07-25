using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Patients
{
    public partial class PatientsView : Form
    {
        public PatientsView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatients addPatients = new AddPatients();
            addPatients.ShowDialog();
        }

        private void PatientsView_Load(object sender, EventArgs e)
        {
            dropdown1.SelectedItem = "--Select--";
            DataGrid();

        }

        private void DataGrid()
        {
            dataGridView1.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList SNameList = new ArrayList();
            ArrayList FNameList = new ArrayList();
            ArrayList EmailList = new ArrayList();
            ArrayList ContactList = new ArrayList();

            for (int i = 0; i <= 10; i++)
            {
                idList.Add(i.ToString());
                SNameList.Add((i + 1).ToString());
                FNameList.Add((i + 2)).ToString();
                EmailList.Add((i + 3).ToString());
                ContactList.Add((i + 4).ToString());
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = idList[i].ToString();
                dataGridView1.Rows[n].Cells[2].Value = SNameList[i].ToString();
                dataGridView1.Rows[n].Cells[3].Value = FNameList[i].ToString();
                dataGridView1.Rows[n].Cells[4].Value = EmailList[i].ToString();

                if(i==3)
                {
                    dataGridView1.Rows[3].Cells[7].Value = Properties.Resources.Circle_Block_blue;
                }

                if (i == 7)
                {
                    dataGridView1.Rows[7].Cells[7].Value = Properties.Resources.Circle_Block_blue;
                }

                if (i == 9)
                {
                    dataGridView1.Rows[9].Cells[7].Value = Properties.Resources.Circle_Block_blue;
                }
            }
        }
    }
}
