using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Teacher
    {
        private readonly int id;
        public int Id => id;
        public string Name { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public Teacher() { }

        public Teacher(int id, string name, IEnumerable<Course> courses)
        {
            this.id = id;
            Name = name;
            Courses = courses;
        }
    }
}
