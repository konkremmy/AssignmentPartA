using System;
using System.Collections.Generic;

namespace AssignmentPartA
{
    public class Student
    {
        

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        
        public List<Course> Courses { get; set; }=new List<Course>();
        public List<Trainer> Trainers { get; set; }=new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public void Print()
        {
            Console.WriteLine($"{StudentId,-25}{FirstName,-25}{LastName,-25}{DateOfBirth,-25}{TuitionFees,-25}");
        }
        public void PrintName()
        {
            Console.WriteLine($"{"",-15}{FirstName,-15}{LastName,-15}");
        }
        public void PrintName2()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }
}
