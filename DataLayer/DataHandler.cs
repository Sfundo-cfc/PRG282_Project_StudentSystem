using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Project_StudentSystem.DataLayer
{
    internal class DataHandler
    {

        public DataHandler() { }

        string filePath = "students.txt";
        public void AddNewStudent(string studentDetails)
        {
            File.AppendAllText(filePath, studentDetails + "\n"); // adds all text in file.
            Console.WriteLine("Students successfully added to the records");

        }
        public List<string> GetAllStudents() // returns the string list from the txt.
        {
            try // to avoid breaks.
            {
                return File.ReadAllLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                List<string> result = new List<string>();
                result.Add("Cannot gather all the students at this moment!");
                return result;// problem so retuns empty list of results.

            }


        }
        public void DeleteStudentRecord(string fullStudentDetail)
        {
            try
            {
                // prompt for user confirmation before deleting.
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {fullStudentDetail} record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes) //test for yes from user.
                {
                    // Read all lines from the text file.
                    List<string> students = File.ReadAllLines(filePath).ToList();

                    // Check if the full student detail exists in the list.
                    if (students.Contains(fullStudentDetail))
                    {
                        students.Remove(fullStudentDetail); // Remove the exact match.

                        // Rewrite the updated list to the file.
                        File.WriteAllLines(filePath, students);
                        MessageBox.Show("Student record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Student not found in the file.");
                    }
                }
                else 
                { 
                    MessageBox.Show("Delete aborted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the student: " + ex.Message);
            }

        }

        public void FileUpdate(string oldRecord, string newRecord)
        {
            try
            {  
                List<string> students = File.ReadAllLines(filePath).ToList();// Reads all students from the text file into a list.

               
                int index = students.IndexOf(oldRecord);  // Find the index of the old student record.

                if (index != -1)
                {
                    students[index] = newRecord; // Replace the old record with the new record at the index specified.

                    // Write the updated list back to the text file.
                    File.WriteAllLines(filePath, students);
                    MessageBox.Show("Student record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Student not found in the file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating student: " + ex.Message);
            }
        }

    }
}




   




