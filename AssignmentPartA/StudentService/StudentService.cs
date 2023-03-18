using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{



    class StudentServices
    {


        private MyDataBase db = new MyDataBase();

        public List<Student> GetStudents()
        {
            return db.Students;
        }

        public void CreateStudent(Student student)
        {
            int lastId = db.Students[db.Students.Count - 1].StudentId;
            student.StudentId = lastId + 1;
            db.Students.Add(student);
        }

        /// //////---------Care------------/////////
    }



    
   
       
    

}
