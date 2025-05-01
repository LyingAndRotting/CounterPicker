using CounterPicker.Domain.Services;
using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHeroByName;

public class GetHeroByNameHandler : IRequestHandler<GetHeroByNameQuery, Domain.Models.Hero?>
{
    private readonly IHeroService _heroService;
    public GetHeroByNameHandler(IHeroService heroService)
    {
        _heroService = heroService;
    }

    public async Task<Domain.Models.Hero?> Handle(GetHeroByNameQuery request, CancellationToken cancellationToken)
    {
        var res = await _heroService.GetByName(request.Name);
        return res;
    }
}