using PRG282_Project_StudentSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PRG282_Project_StudentSystem.BusinessLogic;


namespace StudentManagementSystem
{
    public partial class frmManage : Form
    {
        DataHandler handler = new DataHandler();
        public frmManage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void frmManage_Load(object sender, EventArgs e)
        {
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Age", "Age");
            dgvStudents.Columns.Add("Course", "Course");

            foreach (var item in handler.GetAllStudents())
            {
                // Assuming item is formatted as "FirstName,LastName,Age,Course"
                string[] fields = item.Split(',');

                if (fields.Length == 4)
                {
                    dgvStudents.Rows.Add(fields[0], fields[1], fields[2], fields[3]);
                }
                // dgvStudents.Rows.Add(item);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("To edit the student details,  ensure the outputs prepopullated with the record clicked are updated as needed then click update button");
        }

        private void frmManage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
