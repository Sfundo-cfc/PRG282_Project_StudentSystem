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

     private void button7_Click(object sender, EventArgs e)
     {
         string name = txtName.Text;
         string surname = txtSurname.Text;
         int age = (int)numAge.Value;
         

         if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(cmbCourse.Text))
         {
             MessageBox.Show("All fields are required, please fill in", "Empty fileds", MessageBoxButtons.OK, MessageBoxIcon.Warning);

         } 
         else 

         if (string.IsNullOrWhiteSpace(name))
         {
             MessageBox.Show("Name is required.", "Please enter name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             txtName.Focus();

         }
         else
         if (string.IsNullOrWhiteSpace(surname))
         {
             MessageBox.Show("Surname is required.", "Please enter surname", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             txtSurname.Focus();
         }

         // Validate age (must be a positive integer)
         else
         if (age < 18 || age > 60)
         {
             MessageBox.Show("Invalid age for univeristy student, age but between 18 and 59!");
         }

         // Validate gender (must be selected from combo box)
         else
         if (cmbCourse.SelectedIndex == -1)
         {
             MessageBox.Show("Please select a cousrse.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             cmbCourse.Focus();

         }
         else
         {
             string course = cmbCourse.SelectedItem.ToString();
         }


     


         string studentDetails = $"{name},{surname},{age},{cmbCourse.Text}";

         // Add to list box
         lsbStudentDetails.Items.Add(studentDetails);

         // Clear input fields after adding
         txtSurname.Clear();
         numAge.Value = 0;
         cmbCourse.SelectedIndex = -1;
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
         List<string> linesToAppend = new List<string>();
         foreach (var item in lsbStudentDetails.Items)
         {
             linesToAppend.Add(item.ToString());
         }

         // Append lines to file
         File.AppendAllLines(filePath, linesToAppend);

         MessageBox.Show("Details saved to students.txt successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

         // Clear the list box after saving
         lsbStudentDetails.Items.Clear();
     }

     private void button2_Click(object sender, EventArgs e)
     {
         this.Close();
     }
 }
}
