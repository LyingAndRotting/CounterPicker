using Microsoft.AspNetCore.Mvc;
using MediatR;
using CounterPicker.Application.Features.Hero.Queries.GetAllHeroes;
using CounterPicker.Application.Features.Hero.Queries.GetHeroById;
using CounterPicker.Application.Features.Hero.Queries.GetHeroByName;
using CounterPicker.Domain.Models;
using CounterPicker.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterPicker.Controllers
{
    [Route("api/heroes/")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        private readonly IMediator _mediator;
        public HeroController(IHeroService heroService, IMediator mediator )
        {
            _heroService = heroService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Board>> GetAll()
        {
            try
            {
                var query = new GetAllHeroesQuery();
                var result = await _mediator.Send(query);
            
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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Hero>> Get(int id)
        {
            try
            {
                var query = new GetHeroByIdQuery(id);
                var result = await _mediator.Send(query);
                if (result == null)
                {
                    return BadRequest("Result is null");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Ok();
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Hero>> Get(string name)
        {
            try
            {
                var query = new GetHeroByNameQuery(name);
                var result = await _mediator.Send(query);
                if (result == null)
                {
                    return BadRequest("Result is null");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Ok();
        }
        
        [HttpPost]
        public void Post()
        {
            
        }

        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            
        }
    }
}
