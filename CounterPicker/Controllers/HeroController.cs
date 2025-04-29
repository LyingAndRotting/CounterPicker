using CounterPicker.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using CounterPicker.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterPicker.Controllers
{
    [Route("api/heroes/")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public ActionResult<Board> GetAll()
        {
            var result = _heroService.GetAll();
            if (result ==  null)
            {
                BadRequest("Result is null");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Hero> Get(int id)
        {
            var result = _heroService.Get(id);
            if (result == null)
            {
                BadRequest("Result is null");
            }
            return Ok(result);
        }

        [HttpPost]
        public void Post()
        {
            
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
