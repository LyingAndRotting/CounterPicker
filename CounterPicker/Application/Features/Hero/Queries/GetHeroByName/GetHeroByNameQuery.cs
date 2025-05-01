using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHeroByName;

public class GetHeroByNameQuery : IRequest<Domain.Models.Hero?>
{
    public GetHeroByNameQuery(string name)
    {
        Name = name;
    }
    public string Name {get; set;}
}