using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_StudentSystem.DataLayer
{
    internal class Students
    {
                     public string Name { get; set; }
             public string LastName { get; set; }
            
             public int StudentId { get; set; }
            
             public string Course { get; set; }
            
             public Students(string name, string lastName, int id, string course)
             {
                 this.Name = name;
                 this.LastName = lastName;
                 this.StudentId = id;
                 this.Course = course;
            
             }
                }
}
