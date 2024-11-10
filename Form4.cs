using PRG282_Project_StudentSystem.BusinessLogic;
using System;
using System.CodeDom;
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
            string summaryFilePath = "summary.txt"; // file path for Summary.txt  stored at bin to all anyone to access without fixed path

            try
            {
               
                string labelSummary = lblSummary.Text;    // get the summary text from the label


                File.AppendAllText(summaryFilePath, labelSummary); // Writes the label text to Summary.txt;

                MessageBox.Show("Summary saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving summary: {ex.Message}");
            }

        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            Business business = new Business();
            business.CountAge(); //extracts all the ages from each line and adds it.. method in business class

            (int studentCount, int totalAge) = business.CountAge(); //returns the turple then store it in varas
            MessageBox.Show($"Total Students: {studentCount}, with Total Age: {totalAge}");

            try
            {
                double Avg = totalAge / studentCount; //calculation
                string date = DateTime.Now.ToString("D"); //generates date of summary
                lblSummary.Text = $"There are {studentCount} records of students with an average age of {Avg}\n {studentCount}: Students ||\t Average Age: {Avg} \n {date} "; //formatting the summary
            }
            catch (Exception ex)
            {

                MessageBox.Show("NO RECORDS, so no Summary to produce!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
