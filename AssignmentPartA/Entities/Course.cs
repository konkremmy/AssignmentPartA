using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace AssignmentPartA
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Stream { get; set; }  

        public List<Student> Students { get; set; }
        public List<Assignment> Assignments { get; set; }=new List<Assignment>();

        public List<Trainer> Trainers { get; set; } = new List<Trainer>(); 
        
        
        


        public void Print()
        {
            Console.WriteLine($"{CourseId,-15}{Title,-15}{Type,-15}{StartDate,-25}{EndDate,-25}{Stream,-25}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-15}");
        }
        public void PrintTitle2()
        {
            Console.WriteLine($"{"",-30}{Title,-15}");
        }

    }
}
