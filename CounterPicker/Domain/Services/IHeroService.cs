using CounterPicker.Domain.Models;

namespace CounterPicker.Domain.Services
{
    public interface IHeroService
    {
        Task<Hero?> Get(int id);
        Task<Board?> GetAll();
    }
}
