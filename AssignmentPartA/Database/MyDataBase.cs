using System;
using System.Collections.Generic;

namespace AssignmentPartA
{
    public class MyDataBase
    {
       
        public List<Student> Students { get; set; } = new List<Student>(); 
        public List<Course> Courses { get; set; } = new List<Course>(); 
        public List<Trainer> Trainers { get; set; } = new List<Trainer>(); 
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
       

        public MyDataBase()
        {
            #region Seeding Students
            Student s1 = new Student()
            {
                StudentId = 1,
                FirstName = "Konstantinos",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1994, 12, 04),
                TuitionFees = 10000
            };
            Student s2 = new Student()
            {
                StudentId = 2,
                FirstName = "Dimitris",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1995, 12, 04),
                TuitionFees = 20000
            };
            Student s3 = new Student()
            {
                StudentId = 3,
                FirstName = "Alexandros",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1996, 12, 04),
                TuitionFees = 30000
            };
            Student s4 = new Student()
            {
                StudentId = 4,
                FirstName = "Aristidis",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1954, 12, 04),
                TuitionFees = 40000
            };
            Student s5 = new Student()
            {
                StudentId = 5,
                FirstName = "Giorgos",
                LastName = "Tsirimokos",
                DateOfBirth = new DateTime(1997, 12, 04),
                TuitionFees = 50000
            };
            Student s6 = new Student()
            {
                StudentId = 6,
                FirstName = "Stauros",
                LastName = "Gouleas",
                DateOfBirth = new DateTime(1998, 12, 04),
                TuitionFees = 60000
            };
            Student s7 = new Student()
            {
                StudentId = 7,
                FirstName = "Paulos",
                LastName = "Kontaras",
                DateOfBirth = new DateTime(1999, 12, 04),
                TuitionFees = 70000
            };
            Student s8 = new Student()
            {
                StudentId = 8,
                FirstName = "Yannis",
                LastName = "Papadopouloss",
                DateOfBirth = new DateTime(2000, 12, 04),
                TuitionFees = 80000
            };
            Student s9 = new Student()
            {
                StudentId = 9,
                FirstName = "Vasilhs",
                LastName = "Miskakhs",
                DateOfBirth = new DateTime(2001, 12, 04),
                TuitionFees = 90000
            };
            Student s10 = new Student()
            {
                StudentId = 10,
                FirstName = "Riana",
                LastName = "Kotsiafiti",
                DateOfBirth = new DateTime(2002, 12, 04),
                TuitionFees = 15000
            };
            Student s11 = new Student()
            {
                StudentId = 11,
                FirstName = "Maria",
                LastName = "Peleki",
                DateOfBirth = new DateTime(2003, 12, 04),
                TuitionFees = 25000
            };
            Student s12 = new Student()
            {
                StudentId = 12,
                FirstName = "Fwteinh",
                LastName = "Soukalopoulou",
                DateOfBirth = new DateTime(2004, 12, 04),
                TuitionFees = 35000
            };
            Student s13 = new Student()
            {
                StudentId = 13,
                FirstName = "Nikos",
                LastName = "Parthenis",
                DateOfBirth = new DateTime(2005, 12, 04),
                TuitionFees = 45000
            };
            Student s14 = new Student()
            {
                StudentId = 14,
                FirstName = "Petros",
                LastName = "Korompos",
                DateOfBirth = new DateTime(1981, 12, 04),
                TuitionFees = 55000
            };
            Student s15 = new Student()
            {
                StudentId = 15,
                FirstName = "Makis",
                LastName = "Xristodoulopoulos",
                DateOfBirth = new DateTime(1980, 12, 04),
                TuitionFees = 65000
            };
            Student s16 = new Student()
            {
                StudentId = 16,
                FirstName = "Tasos",
                LastName = "Mpoukas",
                DateOfBirth = new DateTime(1982, 12, 04),
                TuitionFees = 75000
            };
            Student s17 = new Student()
            {
                StudentId = 17,
                FirstName = "Swthria",
                LastName = "Mpelou",
                DateOfBirth = new DateTime(1983, 12, 04),
                TuitionFees = 85000
            };
            Student s18 = new Student()
            {
                StudentId = 18,
                FirstName = "Tzenh",
                LastName = "Vanou",
                DateOfBirth = new DateTime(1984, 12, 04),
                TuitionFees = 95000
            };
            Student s19 = new Student()
            {
                StudentId = 19,
                FirstName = "Rena",
                LastName = "Koumioti",
                DateOfBirth = new DateTime(1985, 12, 04),
                TuitionFees = 53000
            };
            Student s20 = new Student()
            {
                StudentId = 20,
                FirstName = "Stratos",
                LastName = "Dionusiou",
                DateOfBirth = new DateTime(1986, 12, 04),
                TuitionFees = 87000
            };

            #endregion
            #region Courses
            Course c1 = new Course()
            {
                CourseId = 1,
                Title="Java1",
                Type="FullTimeJava",
                StartDate=new DateTime(2019,1,1),
                EndDate=new DateTime(2019,3,31),
                Stream="A1"
            };
            c1.Students = new List<Student> { s1, s3, s5 ,s11,s12};
            s1.Courses.Add(c1);
            s3.Courses.Add(c1);
            s5.Courses.Add(c1);
            s11.Courses.Add(c1);
            s12.Courses.Add(c1);
            
            
            

            Course c2 = new Course()
            {
                CourseId = 2,
                Title = "Java2",
                Type = "PartTimeJava",
                StartDate = new DateTime(2019,2,2),
                EndDate = new DateTime(2019,4,4),
                Stream = "A2"
            };
            c2.Students = new List<Student> { s2, s4, s6,s13,s14 };
            s2.Courses.Add(c2);
            s4.Courses.Add(c2);
            s6.Courses.Add(c2);
            s13.Courses.Add(c2);
            s14.Courses.Add(c2);

            Course c3 = new Course()
            {
                CourseId = 3,
                Title = "C#",
                Type = "FullTimeC#",
                StartDate = new DateTime(2019,3,3),
                EndDate = new DateTime(2019,5,30),
                Stream = "B1"
            };
            c3.Students=new List<Student> { s7,s9,s15,s16,s17 };
            s7.Courses.Add(c3);
            s9.Courses.Add(c3);
            s15.Courses.Add(c3);
            s16.Courses.Add(c3);
            s17.Courses.Add(c3);

            Course c4 = new Course()
            {
                CourseId = 4,
                Title = "C#2",
                Type = "PartTimeC#",
                StartDate = new DateTime(2019,4,4),
                EndDate = new DateTime(2019,6,30),
                Stream = "B2"
            };
            c4.Students=new List<Student> { s8,s10,s18,s19,s20 };
            s8.Courses.Add(c4);
            s10.Courses.Add(c4);
            s18.Courses.Add(c4);
            s19.Courses.Add(c4);
            s20.Courses.Add(c4);

            #endregion
            #region Trainers
            Trainer t1 = new Trainer()
            {
                TrainerId = 1,
                FirstName="Kostas",
                LastName="Makris",
                Subject="Js"
                
            };
            t1.Students=new List<Student>() { s1, s2 };
            s1.Trainers.Add(t1);
            s2.Trainers.Add(t1);
            t1.Courses=new List<Course>() { c1};
            c1.Trainers.Add(t1);
            

            Trainer t2 = new Trainer()
            {
                TrainerId = 2,
                FirstName = "Hlias",
                LastName = "Karagiorgos",
                Subject = "Css"

            };
            t2.Students=new List<Student>() { s3, s4 };
            s3.Trainers.Add(t2);
            s4.Trainers.Add(t2);
            t2.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t2);

            Trainer t3 = new Trainer()
            {
                TrainerId = 3,
                FirstName = "Lakis",
                LastName = "Peppas",
                Subject = "Html"

            };
            t3.Students=new List<Student>() { s5, s6 };
            s5.Trainers.Add(t3);
            s6.Trainers.Add(t3);
            t3.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t3);

            Trainer t4 = new Trainer()
            {
                TrainerId = 4,
                FirstName = "Aggelos",
                LastName = "Dionusiou",
                Subject = "Javascript"

            };
            t4.Students=new List<Student>() { s7, s8 }; 
            s7.Trainers.Add(t4);
            s8.Trainers.Add(t4);
            t4.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t4);

            Trainer t5 = new Trainer()
            {
                TrainerId = 5,
                FirstName = "Spiros",
                LastName = "Denekes",
                Subject = "Jquery"

            };
            t5.Students=new List<Student>() { s9, s10, s11 };
            s9.Trainers.Add(t5);
            s10.Trainers.Add(t5);
            s11.Trainers.Add(t5);
            t5.Courses = new List<Course>() { c1 };
            c1.Trainers.Add(t5);

            Trainer t6 = new Trainer()
            {
                TrainerId = 6,
                FirstName = "Thodoris",
                LastName = "Kokkalis",
                Subject = "Typescript"

            };
            t6.Students=new List<Student>() { s12, s13,s14 };
            s12.Trainers.Add(t6);
            s13.Trainers.Add(t6);   
            s14.Trainers.Add(t6);
            t6.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t6);

            Trainer t7 = new Trainer()
            {
                TrainerId = 7,
                FirstName = "Marios",
                LastName = "Sxoinas",
                Subject = "Sql"

            };
            t7.Students=new List<Student>() { s15, s16, s17 };
            s15.Trainers.Add(t7);
            s16.Trainers.Add(t7);
            s17.Trainers.Add(t7);
            t7.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t7);

            Trainer t8 = new Trainer()
            {
                TrainerId = 8,
                FirstName = "Fotis",
                LastName = "Lekas",
                Subject = "Bootstrap"

            };
            t8.Students=new List<Student>() { s18, s19,s20 };
            s18.Trainers.Add(t8);
            s19.Trainers.Add(t8);
            s20.Trainers.Add(t8);
            t8.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t8);
            #endregion
            #region Assignments
            Assignment a1 = new Assignment()
            {
                AssignmentId = 1,
                Title="Ass1",
                Description="JavaForms",
                OralMark=11,
                TotalMark=50,
                SubDateTime= new DateTime(2019,2,2)
            };
            a1.Courses.Add(c1);
            c1.Assignments.Add(a1);

            Assignment a2 = new Assignment()
            {
                AssignmentId = 2,
                Title = "Ass2",
                Description = "JavaTypes",
                OralMark = 15,
                TotalMark = 60,
                SubDateTime = new DateTime(2019,3,2)
            };
            a2.Courses.Add(c1);
            c1.Assignments.Add(a2);

            Assignment a3 = new Assignment()
            {
                AssignmentId = 3,
                Title = "Ass3",
                Description = "Classes",
                OralMark = 13,
                TotalMark = 610,
                SubDateTime = new DateTime(2019,4,2)
            };
            a3.Courses.Add(c1);
            c1.Assignments.Add(a3);

            Assignment a4 = new Assignment()
            {
                AssignmentId = 4,
                Title = "Ass4",
                Description = "Functions",
                OralMark = 14,
                TotalMark = 62,
                SubDateTime = new DateTime(2019,5,2)
            };
            a4.Courses.Add(c1);
            c1.Assignments.Add(a4);

            Assignment a5 = new Assignment()
            {
                AssignmentId = 5,
                Title = "Ass5",
                Description = "DoWhile",
                OralMark = 15,
                TotalMark = 63,
                SubDateTime = new DateTime(2019,6,2)
            };
            a5.Courses.Add(c1);
            c1.Assignments.Add(a5);

            Assignment a6 = new Assignment()
            {
                AssignmentId = 6,
                Title = "Ass1",
                Description = "For",
                OralMark = 15,
                TotalMark = 64,
                SubDateTime = new DateTime(2019,7,2)
            };
            a6.Courses.Add(c1);
            c1.Assignments.Add(a6);

            Assignment a7 = new Assignment()
            {
                AssignmentId = 7,
                Title = "Ass7",
                Description = "ForEach",
                OralMark = 16,
                TotalMark = 65,
                SubDateTime = new DateTime(2019,8,2)
            };
            a7.Courses.Add(c1);
            c1.Assignments.Add(a7);

            Assignment a8 = new Assignment()
            {
                AssignmentId = 8,
                Title = "Ass8",
                Description = "Switch",
                OralMark = 16,
                TotalMark = 66,
                SubDateTime = new DateTime(2019,9,2)
            };
            a8.Courses.Add(c2);
            c2.Assignments.Add(a8);

            Assignment a9 = new Assignment()
            {
                AssignmentId = 9,
                Title = "Ass9",
                Description = "If",
                OralMark = 17,
                TotalMark = 67,
                SubDateTime = new DateTime(2019,10,2)
            };
            a9.Courses.Add(c2);
            c2.Assignments.Add(a9);

            Assignment a10 = new Assignment()
            {
                AssignmentId = 10,
                Title = "Ass10",
                Description = "IfElse",
                OralMark = 18,
                TotalMark = 68,
                SubDateTime = new DateTime(2019,11,2)
            };
            a10.Courses.Add(c2);
            c2.Assignments.Add(a10);

            Assignment a11 = new Assignment()
            {
                AssignmentId = 11,
                Title = "Ass11",
                Description = "Entities",
                OralMark = 19,
                TotalMark = 69,
                SubDateTime = new DateTime(2019,12,2)
            };
            a11.Courses.Add(c2);
            c2.Assignments.Add(a11);

            Assignment a12 = new Assignment()
            {
                AssignmentId = 12,
                Title = "Ass12",
                Description = "Enums",
                OralMark = 20,
                TotalMark = 70,
                SubDateTime = new DateTime(2019,2,3)
            };
            a12.Courses.Add(c2);
            c2.Assignments.Add(a12);

            Assignment a13 = new Assignment()
            {
                AssignmentId = 13,
                Title = "Ass13",
                Description = "Database",
                OralMark = 20,
                TotalMark = 71,
                SubDateTime = new DateTime(2019,2,4)
            };
            a13.Courses.Add(c2);
            c2.Assignments.Add(a13);

            Assignment a14 = new Assignment()
            {
                AssignmentId = 14,
                Title = "Ass14",
                Description = "Abstract",
                OralMark = 20,
                TotalMark = 72,
                SubDateTime = new DateTime(2019,2,5)
            };
            a14.Courses.Add(c2);
            c2.Assignments.Add(a14);

            Assignment a15 = new Assignment()
            {
                AssignmentId = 15,
                Title = "Ass15",
                Description = "Public",
                OralMark = 20,
                TotalMark = 73,
                SubDateTime = new DateTime(2019,2,6)
            };
            a15.Courses.Add(c3);
            c3.Assignments.Add(a15);

            Assignment a16 = new Assignment()
            {
                AssignmentId = 16,
                Title = "Ass16",
                Description = "Void",
                OralMark = 20,
                TotalMark = 74,
                SubDateTime = new DateTime(2019,2,7)
            };
            a16.Courses.Add(c3);
            c3.Assignments.Add(a16);

            Assignment a17 = new Assignment()
            {
                AssignmentId = 17,
                Title = "Ass18",
                Description = "Private",
                OralMark = 20,
                TotalMark = 75,
                SubDateTime = new DateTime(2019,2,8)
            };
            a17.Courses.Add(c3);
            c3.Assignments.Add(a17);

            Assignment a18 = new Assignment()
            {
                AssignmentId = 18,
                Title = "Ass18",
                Description = "Arrays",
                OralMark = 20,
                TotalMark = 76,
                SubDateTime = new DateTime(2019,2,9)
            };
            a18.Courses.Add(c3);
            c3.Assignments.Add(a18);

            Assignment a19 = new Assignment()
            {
                AssignmentId = 19,
                Title = "Ass19",
                Description = "Lists",
                OralMark = 20,
                TotalMark = 77,
                SubDateTime = new DateTime(2019,2,10)
            };
            a19.Courses.Add(c3);
            c3.Assignments.Add(a19);

            Assignment a20 = new Assignment()
            {
                AssignmentId = 20,
                Title = "Ass20",
                Description = "String",
                OralMark = 20,
                TotalMark = 78,
                SubDateTime = new DateTime(2019,2,11)
            };
            a20.Courses.Add(c3);
            c3.Assignments.Add(a20);

            Assignment a21 = new Assignment()
            {
                AssignmentId = 21,
                Title = "Ass21",
                Description = "Int",
                OralMark = 20,
                TotalMark = 79,
                SubDateTime = new DateTime(2019,2,12)
            };
            a21.Courses.Add(c3);
            c3.Assignments.Add(a21);

            Assignment a22 = new Assignment()
            {
                AssignmentId = 22,
                Title = "Ass22",
                Description = "Bool",
                OralMark = 20,
                TotalMark = 80,
                SubDateTime = new DateTime(2019,2,13)
            };
            a22.Courses.Add(c4);
            c4.Assignments.Add(a22);

            Assignment a23 = new Assignment()
            {
                AssignmentId = 23,
                Title = "Ass23",
                Description = "Double",
                OralMark = 20,
                TotalMark = 90,
                SubDateTime = new DateTime(2019,2,14)
            };
            a23.Courses.Add(c4);
            c4.Assignments.Add(a23);

            Assignment a24 = new Assignment()
            {
                AssignmentId = 24,
                Title = "Ass24",
                Description = "Long",
                OralMark = 20,
                TotalMark = 91,
                SubDateTime = new DateTime(2019,2,15)
            };
            a24.Courses.Add(c4);
            c4.Assignments.Add(a24);

            Assignment a25 = new Assignment()
            {
                AssignmentId = 25,
                Title = "Ass25",
                Description = "Static",
                OralMark = 20,
                TotalMark = 92,
                SubDateTime = new DateTime(2019,2,16)
            };
            a25.Courses.Add(c4);
            c4.Assignments.Add(a25);

            Assignment a26 = new Assignment()
            {
                AssignmentId = 26,
                Title = "Ass26",
                Description = "Interfaces",
                OralMark = 20,
                TotalMark = 93,
                SubDateTime = new DateTime(2019,2,17)
            };
            a26.Courses.Add(c4);
            c4.Assignments.Add(a26);

            Assignment a27 = new Assignment()
            {
                AssignmentId = 27,
                Title = "Ass27",
                Description = "Restrictions",
                OralMark = 20,
                TotalMark = 94,
                SubDateTime = new DateTime(2019,2,18)
            };
            a27.Courses.Add(c4);
            c4.Assignments.Add(a27);

            Assignment a28 = new Assignment()
            {
                AssignmentId = 28,
                Title = "Ass28",
                Description = "Validations",
                OralMark = 20,
                TotalMark = 95,
                SubDateTime = new DateTime(2019,2,19)
            };
            a28.Courses.Add(c4);
            c4.Assignments.Add(a28);

            #endregion

            #region PopulateLists
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, };
            Students.AddRange(students);

            List<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            Courses.AddRange(courses);

            List<Trainer> trainers = new List<Trainer> { t1, t2, t3, t4, t5, t6, t7, t8 };
            Trainers.AddRange(trainers);

            List<Assignment> assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            Assignments.AddRange(assignments);
            
            #endregion
           
        }


    }
}

