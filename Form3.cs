using StudentManagementSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManagementSystem.BusinessLogic;
using StudentManagementSystem.PresentationLayer;
using PRG282_Project_StudentSystem.DataLayer;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtFillName.Visible = true;
            txtFillLastName.Visible = true;
            cmbFillCourse.Visible = true;
            numFillAge.Visible = true;



            if (dgvStudents.SelectedRows.Count > 0)
            {
                // Retrieve the current details of the selected student from the DataGridView
                string oldFirstName = dgvStudents.SelectedRows[0].Cells["FirstName"].Value.ToString();
                string oldLastName = dgvStudents.SelectedRows[0].Cells["LastName"].Value.ToString();
                string oldAge = dgvStudents.SelectedRows[0].Cells["Age"].Value.ToString();
                string oldCourse = dgvStudents.SelectedRows[0].Cells["Course"].Value.ToString();

                // Construct the old record
                string oldRecord = $"{oldFirstName},{oldLastName},{oldAge},{oldCourse}";

                // Get updated data from the input fields
                string newFirstName = txtFillName.Text;
                string newLastName = txtFillLastName.Text;
                string newAge = numFillAge.Value.ToString();
                string newCourse = cmbFillCourse.Text;

                // Construct the new record
                string newRecord = $"{newFirstName},{newLastName},{newAge},{newCourse}";

                // Update the DataGridView with the new values
                dgvStudents.SelectedRows[0].Cells["FirstName"].Value = newFirstName;
                dgvStudents.SelectedRows[0].Cells["LastName"].Value = newLastName;
                dgvStudents.SelectedRows[0].Cells["Age"].Value = newAge;
                dgvStudents.SelectedRows[0].Cells["Course"].Value = newCourse;

                // Update the text file
                handler.FileUpdate(oldRecord, newRecord);
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
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
            }

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
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("To edit the student details,  ensure the outputs prepopullated with the record clicked are updated as needed then click update button");
        }
    }
}
