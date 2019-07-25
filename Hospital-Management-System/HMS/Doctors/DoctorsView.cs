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
using System.Windows.Forms.VisualStyles;

namespace HMS.Doctors
{
    public partial class DoctorsView : Form
    {
        public DoctorsView()
        {
            InitializeComponent();

        }

        
        private void Doctors_Load(object sender, EventArgs e)
        {
            dropdown1.SelectedItem = "--Select--";

            dataGridView1.Columns[0].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGrid();
            

        }


        private void servoFlatButton1_Click(object sender, EventArgs e)
        {
            AddDoctor dctr = new AddDoctor();
            dctr.ShowDialog();
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
            }
        }
    }
}