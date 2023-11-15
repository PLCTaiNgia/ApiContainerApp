using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiContainer.Dto
{
    public class AddBookingDto
    {

        [Required]
        [JsonPropertyName("ContainerId")]
        public string ContainerId { get; set; }

    }
}
