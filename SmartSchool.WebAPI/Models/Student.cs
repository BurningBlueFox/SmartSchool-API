using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Student
    {
        private readonly int id;

        public int Id => id;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
        public Student() { }
        public Student(int id, string firstName, string lastName, string telephoneNumber)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
        }

    }
}
