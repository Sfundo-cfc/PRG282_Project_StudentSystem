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

            try // avoid any errors
            {
                if (!File.Exists(filePath)) // testing for path 
                {
                    MessageBox.Show("File not found.");

                    return (studentCount, totalAge);
                }

                // Read all lines from the file
                string[] studentLines = File.ReadAllLines(filePath);

                foreach (string line in studentLines)
                {
                    string[] fields = line.Split(','); //uses comma to split the line of student data and store as array 

                    if (fields.Length >= 3 && int.TryParse(fields[2], out int age)) //gets the age at index 2
                    {
                       
                        studentCount++;  // Increments the student count 
                        totalAge += age; //add age to totalAge
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing file: {ex.Message}");
            }

            return (studentCount, totalAge); // will still return the unassigned variables .. was a problem
        }



    }

}

