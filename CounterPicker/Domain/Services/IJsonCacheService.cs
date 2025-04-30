using CounterPicker.Domain.Models;

namespace CounterPicker.Domain.Services
{
    public interface IJsonCacheService
    {
        public Task<Board?> GetDataAsync();
    }
}
