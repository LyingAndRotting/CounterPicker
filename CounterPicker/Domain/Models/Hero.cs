using System.Text.Json.Serialization;

namespace CounterPicker.Domain.Models
{
    public class Hero
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("localized_name")]
        public string? LocalizedName { get; set; } 
    }
}
