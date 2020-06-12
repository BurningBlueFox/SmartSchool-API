using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Course
    {
        private readonly int id;
        public int Id => id;
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
        public Course() { }

        public Course(int id, string name, int teacherId)
        {
            this.id = id;
            Name = name;
            TeacherId = teacherId;
        }
    }
}
