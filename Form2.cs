using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Project_StudentSystem
{ 
    
  public partial class frmAddStudent : Form
     {
     public frmAddStudent()
     {
         InitializeComponent();
     }

     private void frmAddStudent_Load(object sender, EventArgs e)
     {
         lsbStudentDetails.Items.Clear();
     }




     private void button2_Click(object sender, EventArgs e)
     {
         this.Close();
     }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int age = (int)numAge.Value;

            // Validate all required fields
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(cmbCourse.Text))
            {
                MessageBox.Show("All fields are required, please fill in", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lsbStudentDetails.Items.Clear();
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Please enter name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                lsbStudentDetails.Items.Clear();
            }
            else if (string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Surname is required.", "Please enter surname", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                lsbStudentDetails.Items.Clear();
            }
            else if (age < 18 || age > 60)
            {
                MessageBox.Show("Invalid age for university student, age must be between 18 and 59!");
                lsbStudentDetails.Items.Clear();
            }
            else if (cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCourse.Focus();
                lsbStudentDetails.Items.Clear();
            }
            else
            {
                // All validations passed, proceed to add the student details
                string course = cmbCourse.SelectedItem.ToString();
                string studentDetails = $"{name}, {surname}, {age}, {course}";

                // Add to list box
                lsbStudentDetails.Items.Add(studentDetails);

                // Clear input fields after adding
                txtName.Clear();
                txtSurname.Clear();
                numAge.Value = 0;
                cmbCourse.SelectedIndex = -1;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsbStudentDetails.Items.Count == 0)
            {
                MessageBox.Show("No details to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string filePath = "students.txt";

            // Convert list box items to a list of strings
            List<string> StudentToAdd = new List<string>();
            foreach (var item in lsbStudentDetails.Items)
            {
                StudentToAdd.Add(item.ToString());
            }

            // Append lines to file
            File.AppendAllLines(filePath, StudentToAdd);

            MessageBox.Show("Details saved to students.txt successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the list box after saving
            lsbStudentDetails.Items.Clear();
        }
    }
}
