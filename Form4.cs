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
    }
}
