using CounterPicker.Domain.Models;
using CounterPicker.Domain.Services;
using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetAllHeroes
{
    public class GetAllHeroesHandler : IRequestHandler<GetAllHeroesQuery, Board?>
    {
        private readonly IHeroService _hero;
        
        public GetAllHeroesHandler(IHeroService hero)
        {
            _hero = hero;
        }

        public async Task<Board?> Handle(GetAllHeroesQuery request, CancellationToken cancellationToken)
        {
            var result = await _hero.GetAll();
            return result;
        }
    }
}
