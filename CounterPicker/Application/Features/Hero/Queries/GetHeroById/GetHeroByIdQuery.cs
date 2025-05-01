using MediatR;

namespace CounterPicker.Application.Features.Hero.Queries.GetHeroById;

public class GetHeroByIdQuery : IRequest<Domain.Models.Hero?>
{
    public GetHeroByIdQuery(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}