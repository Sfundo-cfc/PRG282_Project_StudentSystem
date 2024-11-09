using PRG282_Project_StudentSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_StudentSystem
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private void btnSaveSummary_Click(object sender, EventArgs e)
        {
            string summaryFilePath = "summary.txt"; // Define the file path for Summary.txt

            try
            {
                // Retrieve text from the label
                string labelText = lblSummary.Text; // Replace myLabel with the actual label's name

                // Write the label text to Summary.txt (overwrites the file if it exists)
                File.AppendAllText(summaryFilePath, labelText);

                MessageBox.Show("Summary saved successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error saving summary: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            Business business = new Business();
            business.CountAge();

            (int studentCount, int totalAge) = business.CountAge();
            MessageBox.Show($"Total Students: {studentCount}, with Total Age: {totalAge}");

            try
            {
                double Avg = totalAge / studentCount;
                string date = DateTime.Now.ToString("D");
                lblSummary.Text = $"There are {studentCount} records of students with an average age of {Avg}\n {studentCount}: Students ||\t {Avg} \n {date} ";
            }
            catch (Exception ex)
            {

                MessageBox.Show("NO RECORDS, so no Summary to produce!");
            }
        }
    }
}
