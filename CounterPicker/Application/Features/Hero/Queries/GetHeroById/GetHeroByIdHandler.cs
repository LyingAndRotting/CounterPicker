using CounterPicker.Domain.Services;
using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHeroById;

public class GetHeroByIdHandler : IRequestHandler<GetHeroByIdQuery, Domain.Models.Hero?>
{ 
    private readonly IHeroService _heroService;

    public GetHeroByIdHandler(IHeroService hero)
    {
        _heroService = hero;
    }

    public async Task<Domain.Models.Hero?> Handle(GetHeroByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _heroService.GetById(request.Id);
        return result;
    }
}
