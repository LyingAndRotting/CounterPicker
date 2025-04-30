using CounterPicker.Domain.Models;
using CounterPicker.Domain.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;


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

            if (_memoryCache.TryGetValue(cacheKey, out Board? cachedBoard))
            {
                return cachedBoard;
            }

            await using var stream = File.OpenRead(_filePath);

            var data = await JsonSerializer.DeserializeAsync<Board>(stream, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
            });

            _memoryCache.Set(cacheKey, data, TimeSpan.FromHours(1));
            return data;
        }
    }
}