using CounterPicker.Domain.Models;
using CounterPicker.Domain.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Text.Json;


namespace CounterPicker.Domain.Services
{
    public class JsonCacheService : IJsonCacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly string _filePath;

        public JsonCacheService(IMemoryCache memoryCache, IConfiguration configuration)
        {
            _memoryCache = memoryCache;
            _filePath = "heroes.json";
        }

        public async Task<Board?> GetDataAsync()
        {
            const string cacheKey = "stariy_bog";

            if (_memoryCache.TryGetValue(cacheKey, out Board? hero))
            {
                return hero;
            }
            string json = await File.ReadAllTextAsync(_filePath);
            var data = JsonSerializer.Deserialize<Board>(json);

            _memoryCache.Set(cacheKey, json, TimeSpan.FromHours(1));
            return data;
        }
    }
}
