using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<Student> students = new List<Student>()
        {
            new Student(1, "José", "Messia", "0800-696969"),
            new Student(2, "Keroline", "Katia", "123456123"),
            new Student(3, "Alberto", "Do mato", "949302932")
        };

        public StudentController()
        {

        }
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(students);
        }

        [HttpGet("byId/{id:int}")]
        public IActionResult GetById(int id)
        {
            Student selectedStudent = students.FirstOrDefault(s => s.Id == id);
            if (selectedStudent == null) return BadRequest("Student not found");
            return Ok(selectedStudent);
        }
        [HttpGet("byName/{name}")]
        public IActionResult GetByName(string name)
        {
            Student selectedStudent = students.FirstOrDefault(s => s.FirstName.Contains(name));
            if (selectedStudent == null) return BadRequest("Student not found");
            return Ok(selectedStudent);
        }
        [HttpPost]
        public IActionResult Post(Student student)
        {
            return Ok(student);
        }
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Student student)
        {
            return Ok(student);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(id);
        }
    }
}
