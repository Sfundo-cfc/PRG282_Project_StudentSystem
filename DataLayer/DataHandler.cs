using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_StudentSystem.DataLayer
{
    internal class DataHandler
    {

        public DataHandler() { }

        string filePath = "students.txt";
        public void AddNewStudent(string studentDetails)
        {
            File.AppendAllText(filePath, studentDetails + "\n");
            Console.WriteLine("Students successfully added to the records");

        }
        public List<string> GetAllStudents()
        {
            try
            {
                return File.ReadAllLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                List<string> result = new List<string>();
                result.Add("Cannot gathher all the students at this moment!");
                return result;

            }


        }
        public void DeleteStudentRecord(string fullStudentDetail)
        {
            try
            {
                // Read all lines from the text file
                List<string> students = File.ReadAllLines(filePath).ToList();

                // Check if the full student detail exists in the list
                if (students.Contains(fullStudentDetail))
                {
                    students.Remove(fullStudentDetail); // Remove the exact match

                    // Rewrite the updated list to the file
                    File.WriteAllLines(filePath, students);
                    MessageBox.Show("Student record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Student not found in the file.");
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
                // Read all students from the text file into a list
                List<string> students = File.ReadAllLines(filePath).ToList();

                // Find the index of the old student record
                int index = students.IndexOf(oldRecord);

                if (index != -1)
                {
                    // Replace the old record with the new record
                    students[index] = newRecord;

                    // Write the updated list back to the text file
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
                MessageBox.Show("An error occurred while updating the student: " + ex.Message);
            }
        }

    }
}




   




