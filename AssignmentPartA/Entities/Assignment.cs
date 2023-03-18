using System;
using System.Collections.Generic;

namespace AssignmentPartA
{
    public class Assignment
    {
        public string Title { get; set; }
        public DateTime SubDateTime { get; set; }
        public int AssignmentId { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public string Description { get; set; }
        public List<Course> Courses { get; set; }= new List<Course>();
        public List<Student> Students { get; set; } 
        public List<Trainer> Trainers { get; set; }
       
        public void Print()
        {
            Console.WriteLine($"{Title,-15}{AssignmentId,-15}{OralMark,-15}{TotalMark,-15}{Description,-15}{SubDateTime,-25}");
        }
        public void PrintTitle()
        {
            Console.WriteLine($"{"",-15}{Title,-15}");
        }
        public void PrintTitle2()
        {
            Console.WriteLine($"{"",-45}{Title,-15}");
        }
    }
}
