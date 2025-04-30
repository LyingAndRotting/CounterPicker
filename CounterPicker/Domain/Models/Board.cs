using System.Text.Json.Serialization;

namespace CounterPicker.Domain.Models
{
    public class Board
    {
        [JsonPropertyName("heroes")]
        public List<Hero>? Heroes { get; init; }
    }
}
