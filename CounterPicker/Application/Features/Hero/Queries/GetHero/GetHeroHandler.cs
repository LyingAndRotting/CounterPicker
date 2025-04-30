using CounterPicker.Domain.Services;
using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHero;

public class GetHeroHandler : IRequestHandler<GetHeroQuery, Domain.Models.Hero?>
{ 
    private readonly IHeroService _hero;

    public GetHeroHandler(IHeroService hero)
    {
        _hero = hero;
    }

    public async Task<Domain.Models.Hero?> Handle(GetHeroQuery request, CancellationToken cancellationToken)
    {
        var result = await _hero.Get(request.Id);
        return result;
    }
}
