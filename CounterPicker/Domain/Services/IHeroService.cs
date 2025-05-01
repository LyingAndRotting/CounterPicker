using CounterPicker.Domain.Models;

namespace CounterPicker.Domain.Services
{
    public interface IHeroService
    {
        Task<Hero?> GetById(int id);
        Task<Board?> GetAll();
        Task<Hero?> GetByName(string requestName);
    }
}
