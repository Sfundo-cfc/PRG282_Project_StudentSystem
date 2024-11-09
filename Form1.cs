using StudentManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_StudentSystem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenuOption_Click(object sender, EventArgs e)
        {

            if (rdbAdd.Checked)
            {
                this.Hide();
                frmAddStudent frmAddStudent = new frmAddStudent();
                frmAddStudent.ShowDialog();
                this.Show();


            }
            else if
                (rdbManage.Checked)
            {
                this.Hide();
                frmManage frmManage = new frmManage();
                frmManage.ShowDialog();
                this.Show();

            }
            else if
                (rdbSummary.Checked)
            {
                this.Hide();
                frmSummary frmSummary = new frmSummary();
                frmSummary.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("*Please note. Menu option not selected!\n   Please make a choice");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + DateTime.Now.ToString("D") + "  ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
