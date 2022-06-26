using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.API.Repositories;
using StudentPortal.API.DomainModels;
using System.Threading.Tasks;

namespace StudentPortal.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var genderList = await studentRepository.GetGenderAsync();

            if (genderList == null || !genderList.Any())
            {
                return NotFound();
            }

            return Ok(mapper.Map<List<GenderDM>>(genderList));
        }
    }
}
