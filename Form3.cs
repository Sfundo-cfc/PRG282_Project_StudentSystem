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
            if (dgvStudents.SelectedRows.Count == 1) // test if a row is selected and only one row at a time
            {
                txtFillName.Visible = true;
                txtFillLastName.Visible = true;
                cmbFillCourse.Visible = true;
                numFillAge.Visible = true;

                btnChanges.Visible = true;
                btnDelete.Visible = false;
                btnRefresh.Visible = false;

                string oldFirstName = dgvStudents.SelectedRows[0].Cells["FirstName"].Value.ToString(); // get the data from data grid view to a variable
                string oldLastName = dgvStudents.SelectedRows[0].Cells["LastName"].Value.ToString();
                string oldAge = dgvStudents.SelectedRows[0].Cells["Age"].Value.ToString();
                string oldCourse = dgvStudents.SelectedRows[0].Cells["Course"].Value.ToString();

       

                // Get updated data from the input boxes
               txtFillName.Text =oldFirstName;
               txtFillLastName.Text=oldLastName;
               numFillAge.Value=int.Parse(oldAge);
                cmbFillCourse.Text= oldCourse;
            }
            else
            {
                MessageBox.Show("Please select one student to update");
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
                //separating by a comma the list returned from GetallStudents to store in an array
                string[] fields = item.Split(',');

                if (fields.Length == 4) 
                {
                    dgvStudents.Rows.Add(fields[0], fields[1], fields[2], fields[3]);
                }
                // dgvStudents.Rows.Add(item); displays one column with all the data 
            }
            btnChanges.Visible = false;
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

            // shows the selected details of the selected student from the DataGridView
            string oldFirstName = dgvStudents.SelectedRows[0].Cells["FirstName"].Value.ToString();
            string oldLastName = dgvStudents.SelectedRows[0].Cells["LastName"].Value.ToString();
            string oldAge = dgvStudents.SelectedRows[0].Cells["Age"].Value.ToString();
            string oldCourse = dgvStudents.SelectedRows[0].Cells["Course"].Value.ToString();


            string oldRecord = $"{oldFirstName},{oldLastName},{oldAge},{oldCourse}";  // Construct the old record

            // Get updated data from the input boxes
            string newFirstName = txtFillName.Text;
            string newLastName = txtFillLastName.Text;
            int newAge = (int)numFillAge.Value;
            string newCourse = cmbFillCourse.Text;

            // Validation 
            if (string.IsNullOrWhiteSpace(newFirstName))
            {
                MessageBox.Show("First name is required.", "Validation Error, Try Aggain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFillName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(newLastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error, Try Aggain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFillLastName.Focus();
                return;
            }
            if (newAge < 18 || newAge > 60)
            {
                MessageBox.Show("Invalid age for a university student. Age must be between 18 and 59.", "Validation Error, Try Aggain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numFillAge.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(newCourse))
            {
                MessageBox.Show("Please select a course.", "Validation Error, Try Aggain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFillCourse.Focus();
                return;
            }

            // Constructs the new record
            string newRecord = $"{newFirstName},{newLastName},{newAge},{newCourse}";

            // Updating the DataGridView with the new values
            dgvStudents.SelectedRows[0].Cells["FirstName"].Value = newFirstName;
            dgvStudents.SelectedRows[0].Cells["LastName"].Value = newLastName;
            dgvStudents.SelectedRows[0].Cells["Age"].Value = newAge.ToString();
            dgvStudents.SelectedRows[0].Cells["Course"].Value = newCourse;

           
            handler.FileUpdate(oldRecord, newRecord);  // Updating the text file

            //clears the data grid and regenerates with new info or update
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Age", "Age");
            dgvStudents.Columns.Add("Course", "Course");

            foreach (var item in handler.GetAllStudents())
            {
               
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
                // Gets the selected row
                var selectedRow = dgvStudents.SelectedRows[0];

                // Checks if any cell in the selected row is null, indicating it's an empty row was thowing an erro
                if (selectedRow.Cells["FirstName"].Value != null &&
                    selectedRow.Cells["LastName"].Value != null &&
                    selectedRow.Cells["Age"].Value != null &&
                    selectedRow.Cells["Course"].Value != null)
                {
                    // Get the student data of the selected student from the DataGridView and store in variables
                    string studentName = selectedRow.Cells["FirstName"].Value.ToString();
                    string studentSurname = selectedRow.Cells["LastName"].Value.ToString();
                    string studentAge = selectedRow.Cells["Age"].Value.ToString();
                    string studentCourse = selectedRow.Cells["Course"].Value.ToString();

                    string fullStudentDetail = $"{studentName},{studentSurname},{studentAge},{studentCourse}"; // Format the full student detail to match the text file format

                    Console.WriteLine(fullStudentDetail);

                    // Removes the student from the text file
                    handler.DeleteStudentRecord(fullStudentDetail);
                }
                else
                {
                    MessageBox.Show("Please select a valid student to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }

            // refrshing the data grid
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Age", "Age");
            dgvStudents.Columns.Add("Course", "Course");

            foreach (var item in handler.GetAllStudents())
            {
                string[] fields = item.Split(',');

                if (fields.Length == 4)
                {
                    dgvStudents.Rows.Add(fields[0], fields[1], fields[2], fields[3]);
                }
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
               
                string[] fields = item.Split(',');

                if (fields.Length == 4)
                {
                    dgvStudents.Rows.Add(fields[0], fields[1], fields[2], fields[3]);
                }
            
            }
        }
    }
}
