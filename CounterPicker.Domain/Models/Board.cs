using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CounterPicker.Domain.Models
{
    public class Board
    {
        [JsonPropertyName("heroes")]
        public List<Hero>? Heroes { get; set; }
    }
}
