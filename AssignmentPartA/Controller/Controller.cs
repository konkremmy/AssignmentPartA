using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{
    class Controller
    {

        StudentServices  service = new StudentServices();
        CourseServices  serviceC = new CourseServices();
        TrainerServices  serviceT = new TrainerServices();
        AssignmentServices  serviceA = new AssignmentServices();
        

        public void ReadAllStudents()
        {
            var allStudents = service.GetStudents();
            View.ViewStudents(allStudents,null);
        }

        public void CreateStudent()
        {
            Student student = View.CreateStudent();
            service.CreateStudent(student);
        }

        CourseServices service1 = new CourseServices();

        public void ReadAllCourses()
        {
            var allCourses = service1.GetCourses();
            View.ViewCourses(allCourses, null);
        }

        public void CreateCourse()
        {
            Course course = View.CreateCourse();
            service1.CreateCourse(course);
        }

        TrainerServices service2 = new TrainerServices();

        public void ReadAllTrainers()
        {
            var allTrainers = service2.GetTrainers();
            View.ViewTrainers(allTrainers, null);
        }

        public void CreateTrainer()
        {
            Trainer trainer = View.CreateTrainer();
            service2.CreateTrainer(trainer);
        }

        AssignmentServices service3 = new AssignmentServices();

        public void ReadAllAssignments()
        {
            var allAssignments = service3.GetAssignments();
            View.ViewAssignments(allAssignments, null);
        }

        public void CreateAssignment()
        {
            Assignment assignment = View.CreateAssignment();
            service3.CreateAssignment(assignment);
        }


    }
}
