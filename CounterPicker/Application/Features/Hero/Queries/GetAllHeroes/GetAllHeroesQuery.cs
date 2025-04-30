using CounterPicker.Domain.Models;
using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetAllHeroes
{
    public class GetAllHeroesQuery : IRequest<Board?>
    {
        public GetAllHeroesQuery()  {}
    }
}
