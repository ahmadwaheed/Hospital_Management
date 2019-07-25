using Animator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            paneladmin.Visible = false;

            menuGroup1.Visible = false;
            menuGroup2.Visible = false;
            menuGroup3.Visible = false;
            menuGroup4.Visible = false;
            menuGroup5.Visible = false;



            toolTip1.SetToolTip(picFacebook, "Like us on Facebook!");
            toolTip1.SetToolTip(picTwitter, "Follow us on Twitter!");
            toolTip1.SetToolTip(picWeb, "Feel free to visit our Website!");
        }

        private void paneladminInfo_MouseEnter(object sender, EventArgs e)
        {
            paneladminInfo.BackColor = Color.FromArgb(54, 127, 169);
        }

        private void paneladminInfo_MouseLeave(object sender, EventArgs e)
        {
            paneladminInfo.BackColor = Color.FromArgb(60, 141, 188);
        }

        private void paneladminInfo_Click(object sender, EventArgs e)
        {
            if (!paneladmin.Visible)
            {
                paneladmin.Visible = true;
                paneladmin.BringToFront();
            }
            else
            {
                paneladmin.Hide();
                paneladmin.SendToBack();
            }
        }



        private void Dropdown_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();

            Panel panel = this.Controls.Find(tag, true).FirstOrDefault() as Panel;

            if (panel.Visible)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            

            //AdminDashboard form = new AdminDashboard();
            //form.TopLevel = false;

            //form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //form.Location = new Point(0, 0);
            //form.Dock = Dock = DockStyle.Fill;
            //panelmain.Controls.Add(form);
            //form.Show();
            //form.BringToFront();
        }

        private BackgroundWorker bw;
        private string FormName = "";
        private Form form;
        private void Show_Form_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                FormName = ((Button)sender).Tag.ToString();
            }

            if (sender is Label)
            {
                FormName = ((Label)sender).Tag.ToString();
            }

            form = Activator.CreateInstance(Type.GetType("HMS." + FormName)) as Form;

            bw = new BackgroundWorker();

            bw.DoWork += bw_DoWork;

            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            LoadingBox.Visible = true;
            bw.RunWorkerAsync();


        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelmain.Invoke(new Action(() => panelmain.Controls.Add(form)));
            form.Show();
            form.BringToFront();
            LoadingBox.Visible = false;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Location = new Point(0, 0);
            form.Dock = Dock = DockStyle.Fill;
        }

        private void Layout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}