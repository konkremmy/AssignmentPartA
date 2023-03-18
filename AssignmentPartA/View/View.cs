using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentPartA
{
    public class View
    {
        public static void ViewStudents(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"StudentId",-25}{"FirstName",-25}{"LastName",-25}{"DateOfBirth",-25}{"TuitionFees",-25}");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.Print();
            }

        }
        public static void ViewCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"CourseId",-15}{"Title",-15}{"Type",-15}{"StartDate",-25}{"EndDate",-25}{"Stream",-25}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.Print();
            }
        }
        public static void ViewTrainers(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-25}{"LastName",-25}{"TrainerId",-25}{"Subject",-25}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                trainer.Print();
            }
        }
        public static void ViewAssignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"AssignmentId",-15}{"OralMark",-15}{"TotalMark",-15}{"Description",-15}{"SubDateTime",-25}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                assignment.Print();
            }
        }
        public static void ViewStudentsPerCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"{"",-30}");
                    student.PrintName();
                    Console.WriteLine();
                }

            }
        }
        public static void ViewTrainersPerCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{"",-30}");
                    trainer.PrintName();
                    Console.WriteLine();
                }

            }
        }
        public static void ViewAssignmentsPerCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"Title",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{"",-30}");
                    assignment.PrintTitle();
                    Console.WriteLine();
                }

            }
        }
        public static void ViewAssignmentsPerStudentPerCourse(List<Student> students, string message, List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Title",-15}{"Title",-15}");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.PrintName2();
                foreach (var course in student.Courses)
                {
                    course.PrintTitle2();

                    foreach (var assignment in course.Assignments)
                    {
                        assignment.PrintTitle2();
                    }
                }
            }
        }
        public static void ViewError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice - Error 404");
            Console.ResetColor();
        }
        public static void ViewExit() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you for visiting us");
            Console.ResetColor();
        }
        public static void ViewMenu()
        {
            const int first = -60;
            const int second = -60;
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"{"----------ALL DATA----------",first}{"----------E FOR EXIT----------",second}");
            Console.WriteLine($"{"1 - Students",first}");
            Console.WriteLine($"{"2 - Courses",first}");
            Console.WriteLine($"{"3 - Trainers",first}");
            Console.WriteLine($"{"4 - Assignments",first}");
            Console.WriteLine($"{"5 - StudentsPerCourse",first}");
            Console.WriteLine($"{"6 - TrainersPerCourse",first}");
            Console.WriteLine($"{"7 - AssignmentsPerCourse",first}");
            Console.WriteLine($"{"8 - AssignmentsPerStudentPerCourse",first}");
            Console.WriteLine($"{"9 - Students Who Have More Than 1 Course",first}");
        }
        public static Student CreateStudent()
        {
            var test=new StudentValidation();
            return test.StudentValidations();           
        }   
        public static Course CreateCourse()
        {

            Console.WriteLine("Give Course's Title");
            string title = Console.ReadLine();

            Console.WriteLine("Give Course's Type");
            string type = Console.ReadLine();

            Console.WriteLine("Give Course's Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Course's Stream");
            string stream = Console.ReadLine();

            Console.WriteLine("Give StartDate");
            DateTime sd = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Give EndDate");
            DateTime ed = Convert.ToDateTime(Console.ReadLine());




            Course obj = new Course()
            {
                Title = title,
                CourseId = id,
                StartDate = sd,
                EndDate = ed,
                Type = type,
                Stream = stream
            };

            return obj;

        }
        public static Trainer CreateTrainer()
        {

            Console.WriteLine("Give Trainer's firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("Give Trainer's lastname");
            string lastname = Console.ReadLine();

            Console.WriteLine("Give Trainer's Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Trainer's Subject");
            string subject = Console.ReadLine();

            Trainer obj = new Trainer()
            {
                FirstName = firstname,
                LastName = lastname,
                TrainerId = id,
                Subject = subject

            };

            return obj;


        }
        public static Assignment CreateAssignment()
        {

            Console.WriteLine("Give Assignment's Title");
            string title = Console.ReadLine();

            Console.WriteLine("Give Assignment's Description");
            string description = Console.ReadLine();

            Console.WriteLine("Give Course's OralMark");
            double oralmark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give Course's TotalMark");
            double total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Assignment's Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give SubDateTime");
            DateTime sdt = Convert.ToDateTime(Console.ReadLine());




            Assignment obj = new Assignment()
            {
                Title = title,
                Description = description,
                OralMark = oralmark,
                TotalMark = total,
                AssignmentId = id,
                SubDateTime = sdt
            };

            return obj;

        }
    }





}

