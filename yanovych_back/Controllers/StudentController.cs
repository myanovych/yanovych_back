using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;
using yanovych_back.Repos;

namespace yanovych_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepo _studentRepo;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepo studentRepo, IMapper mapper)
        {
            _studentRepo = studentRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(_studentRepo.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Add(StudentView student)
        {
            var newStudent = _studentRepo.Add(_mapper.Map<StudentView, Student>(student));

            return CreatedAtAction(nameof(GetById), new { id = newStudent.Id }, newStudent);
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {

            if (_studentRepo.GetById(student.Id) == null)
            {
                return NotFound();
            };

            _studentRepo.Update(student);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(int id)
        {
            if (_studentRepo.GetById(id) == null)
            {
                return NotFound();
            };

            _studentRepo.DeleteById(id);

            return NoContent();
        }
    }
}
