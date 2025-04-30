using CounterPicker.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using CounterPicker.Domain.Models;
using MediatR;
using CounterPicker.Application.Features.Hero.Queries.GetAllHeroes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterPicker.Controllers
{
    [Route("api/heroes/")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        private IMediator _mediator;
        public HeroController(IHeroService heroService, IMediator mediator )
        {
            _heroService = heroService;
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult<Board> GetAll()
        {
            try
            {
                var query = new GetAllHeroesQuery();
                var result = _mediator.Send(query);
            
                if (result ==  null)
                {
                    BadRequest("Result is null");
            }
            return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Ok();
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
