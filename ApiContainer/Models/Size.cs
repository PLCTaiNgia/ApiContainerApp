using System.Text.Json.Serialization;

namespace ApiContainer.Models
{
    public class Size
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("Value")]
        public int Value { get; set; }
    }
}
