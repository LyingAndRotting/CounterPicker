using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHero;

public class GetHeroQuery : IRequest<Domain.Models.Hero?>
{
    public GetHeroQuery(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}