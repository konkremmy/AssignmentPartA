using System;
using System.Dynamic;


namespace AssignmentPartA
{
    class Application
    {
        public static void Run()
        {
            MyDataBase db = new MyDataBase();
            
            string input;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To KremmySchool");
            Console.WriteLine("Press C to Create Your Data//Whatever Else to See Our Data");
            input=Console.ReadLine();
            Controller controller = new Controller(); 
                                
            if (input == "c" || input == "C")
            {
                do
                {
                    Console.WriteLine("Lets Create Your Student");
                    controller.CreateStudent();
                    controller.ReadAllStudents();
                    Console.WriteLine("Press f to continue to Courses");
                    input = Console.ReadLine();
                } while (input!="f");                
                do
                {
                    Console.WriteLine("Lets Create Your Course");
                    controller.CreateCourse();
                    controller.ReadAllCourses();
                    Console.WriteLine("Press f to continue to Trainers");
                    input = Console.ReadLine();
                } while (input != "f");
                do
                {
                    Console.WriteLine("Lets Create Your Trainer");
                    controller.CreateTrainer();
                    controller.ReadAllTrainers();
                    Console.WriteLine("Press f to continue to Assignments");
                    input = Console.ReadLine();
                } while (input != "f");
                do
                {
                    Console.WriteLine("Lets Create Your Assignment");
                    controller.CreateAssignment();
                    controller.ReadAllAssignments();
                    Console.WriteLine("Press f to finish");
                    input = Console.ReadLine();
                } while (input != "f");
            }
            else
            {                 
                do
                {
                  View.ViewMenu();

                  input = Console.ReadLine();
                  Console.Clear();

                  Controller(db, input);

                } while (input != "E" && input != "e");                                                    
            }
        }
        public static void Controller(MyDataBase db, string input)
        {
            switch (input)
            {
                case "1": View.ViewStudents(db.Students, "All Students"); break;
                case "2": View.ViewCourses(db.Courses, "All Courses"); break;
                case "3": View.ViewTrainers(db.Trainers, "All Trainers"); break;
                case "4": View.ViewAssignments(db.Assignments, "All Assignments"); break;
                case "5": View.ViewStudentsPerCourses(db.Courses, "All StudentsPerCourses"); break;
                case "6": View.ViewTrainersPerCourses(db.Courses, "All TrainersPerCourses"); break;
                case "7": View.ViewAssignmentsPerCourses(db.Courses, "All AssignmentsPerCourses"); break;
                case "8": View.ViewAssignmentsPerStudentPerCourse(db.Students, "All AssignmentsPerStudentPerCourse", db.Courses); break;
                case "9": Console.ForegroundColor = ConsoleColor.Red; Console.Clear(); Console.WriteLine("All Students Have Only 1 Course"); break;
                case "e": View.ViewExit(); break;
                case "E": View.ViewExit(); break;
                default: View.ViewError(); break;
            }
        }
    }   
}

