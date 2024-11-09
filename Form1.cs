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
    public partial class frmManage : Form
    {
        public frmManage()
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
                MessageBox.Show("* Menu option not selected!\n   Please make a choice");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
