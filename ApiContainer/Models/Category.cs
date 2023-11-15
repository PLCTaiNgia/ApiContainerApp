using System.Text.Json.Serialization;

namespace ApiContainer.Models
{
    public class Category
    {
        [JsonPropertyName("OprId")]
        public string OprId { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }
}
