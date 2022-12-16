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
    public class LabController : ControllerBase
    {

        private readonly ILabRepo _labRepo;
        private readonly IMapper _mapper;

        public LabController(ILabRepo labRepo, IMapper mapper)
        {
            _labRepo = labRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(_labRepo.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var lab = _labRepo.GetById(id);
            if (lab == null)
            {
                return NotFound();
            }

            return Ok(lab);
        }

        [HttpPost]
        public IActionResult Add(LabView lab)
        {
            var newLab = _labRepo.Add(_mapper.Map<LabView, Lab>(lab));

            return CreatedAtAction(nameof(GetById), new { id = newLab.Id }, newLab);
        }

        [HttpPut]
        public IActionResult Update(Lab lab)
        {

            if (_labRepo.GetById(lab.Id) == null)
            {
                return NotFound();
            };

            _labRepo.Update(lab);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(int id)
        {
            if (_labRepo.GetById(id) == null)
            {
                return NotFound();
            };

            _labRepo.DeleteById(id);

            return NoContent();
        }
    }
}
