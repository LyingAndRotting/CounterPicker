using CounterPicker.Domain.Models;

namespace CounterPicker.Domain.Services
{
    public class HeroService : IHeroService
    {
        private readonly IJsonCacheService _jsonService;
        public HeroService(IJsonCacheService jsonService) 
        {
            _jsonService = jsonService;
        }
        public async Task<Board?> GetAll()
        {
            var data = await _jsonService.GetDataAsync();
            if (data == null)
            {
                return null;
            }
            return data;
        }

        public async Task<Hero?> Get(int id)
        {
            if (id is < 1 or > 126)
            {
               
                return null;
            }
            var data = await _jsonService.GetDataAsync();
            return data?.Heroes?.FirstOrDefault(p => p.Id == id);
        }

    }
}
