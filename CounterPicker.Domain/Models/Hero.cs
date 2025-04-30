using System.Text.Json.Serialization;

namespace CounterPicker.Domain.Models
{
    public class Hero
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("localize_name")]
        public string? localized_name { get; set; } 
    }
}
