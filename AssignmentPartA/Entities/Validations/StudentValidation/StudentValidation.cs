using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{
    public class StudentValidation
    {
        public Student StudentValidations()
        {                   
            string firstname;
            do
            {
                Console.WriteLine("Give Student's Firstname");
                firstname = Console.ReadLine();

            } while (string.IsNullOrEmpty(firstname) || !firstname.All(Char.IsLetter) || firstname.Length >= 20);

            string lastname;
            do
            {
                Console.WriteLine("Give Student's Lastname");
                lastname = Console.ReadLine();

            } while (string.IsNullOrEmpty(lastname) || !lastname.All(Char.IsLetter) || lastname.Length >= 25);

            string idfirst;
            int id;
            do
            {
                Console.WriteLine("Give Student's Id");
                idfirst = Console.ReadLine();

            } while (string.IsNullOrEmpty(idfirst) || !idfirst.All(Char.IsNumber) || idfirst.Length >= 5);
            id = Convert.ToInt32(idfirst);

            string feesfirst;
            int fees;
            do
            {
                Console.WriteLine("Give Tuitionfees");
                feesfirst = Console.ReadLine();

            } while (string.IsNullOrEmpty(feesfirst) || !feesfirst.All(Char.IsNumber) || feesfirst.Length >= 10);
            fees = Convert.ToInt32(feesfirst);

            string dobfirst;
            DateTime dob;
            do
            {
                Console.WriteLine("Give DateOfBirth");
                dobfirst = Console.ReadLine();
            } while (string.IsNullOrEmpty(feesfirst) || !DateTime.TryParse(dobfirst, out dob) || !(dob >= DateTime.Now && dob <= new DateTime(2019 - 3 - 3)));
            dob = Convert.ToDateTime(dobfirst);

            Student obj = new Student()
            {
                FirstName = firstname,
                LastName = lastname,
                StudentId = id,
                TuitionFees = fees,
                DateOfBirth = dob,
            };
            
            return obj;
        }
    }
}
