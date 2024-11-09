using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project_StudentSystem.BusinessLogic
{
    internal class Business
    {
        string filePath = "students.txt";
        public (int studentCount, int totalAge) CountAge()
        {
            int studentCount = 0;
            int totalAge = 0;

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");

                    return (studentCount, totalAge);
                }

                // Read all lines from the file
                string[] studentLines = File.ReadAllLines(filePath);

                foreach (string line in studentLines)
                {
                    string[] fields = line.Split(',');

                    if (fields.Length >= 3 && int.TryParse(fields[2], out int age))
                    {
                        // Increment the student count and add age to totalAge
                        studentCount++;
                        totalAge += age;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error accessing file: {ex.Message}");
            }

            return (studentCount, totalAge);
        }

    }

}

