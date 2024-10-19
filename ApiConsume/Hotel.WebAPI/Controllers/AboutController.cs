using AutoMapper;
using Hotel.Business.Abstract;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var values = _mapper.Map<About>(about);
            _aboutService.TInsert(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var values = _mapper.Map<About>(about);
            _aboutService.TUpdate(values);

            return Ok("Güncelleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok();
        }
    }
}
