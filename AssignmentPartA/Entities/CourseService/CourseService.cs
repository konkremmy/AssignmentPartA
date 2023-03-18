using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{
    class CourseServices
    {
        private MyDataBase db = new MyDataBase();

        public List<Course> GetCourses()
        {
            return db.Courses;
        }

        public void CreateCourse(Course course)
        {
            int lastId = db.Courses[db.Courses.Count - 1].CourseId;
            course.CourseId = lastId + 1;
            db.Courses.Add(course);
        }
    }
}
