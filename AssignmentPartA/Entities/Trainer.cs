using System;
using System.Collections.Generic;

namespace AssignmentPartA
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TrainerId { get; set; }
        public string Subject { get; set; } 
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Assignment> Assignments { get; set; }
        public void Print()
        {
            Console.WriteLine($"{FirstName,-25}{LastName,-25}{TrainerId,-25}{Subject,-25}");
        }
        public void PrintName()
        {
            Console.WriteLine($"{"",-15}{FirstName,-15}{LastName,-15}");
        }
    }
}
