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
            txtFillName.Visible = true;
            txtFillLastName.Visible = true;
            cmbFillCourse.Visible = true;
            numFillAge.Visible = true;

            btnChanges.Visible = true;
            btnDelete.Visible = false;
            btnRefresh.Visible = false;


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


        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("To edit the student details,  ensure the outputs prepopullated with the record clicked are updated as needed then click update button");
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

  



        private void btnChanges_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnChanges.Visible = false;
            btnRefresh.Visible = true;
            btnUpdate.Visible = true;

            txtFillName.Visible = false;
            txtFillLastName.Visible = false;
            cmbFillCourse.Visible = false;
            numFillAge.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                // Get the name, surname, age, and course of the selected student from the DataGridView
                string studentName = dgvStudents.SelectedRows[0].Cells["FirstName"].Value.ToString();
                string studentSurname = dgvStudents.SelectedRows[0].Cells["LastName"].Value.ToString();
                string studentAge = dgvStudents.SelectedRows[0].Cells["Age"].Value.ToString();
                string studentCourse = dgvStudents.SelectedRows[0].Cells["Course"].Value.ToString();

                // Format the full student detail to match the text file format


                string fullStudentDetail = $"{studentName},{studentSurname},{studentAge},{studentCourse}";

                Console.WriteLine(fullStudentDetail);

                // Remove the student from the text file
                handler.DeleteStudentRecord(fullStudentDetail);
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
    }
}
