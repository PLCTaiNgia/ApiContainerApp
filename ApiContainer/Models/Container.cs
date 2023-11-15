using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiContainer.Models
{
    public class Container
    {
        [Required]
        [JsonPropertyName("CntrNo")]
        public string CntrNo { get; set; } // Số container

        [Required]
        [JsonPropertyName("CntrSize")]
        public int CntrSize { get; set; } // Kích cỡ

        [Required]
        [JsonPropertyName("OprId")]
        public string OprId { get; set; }// Hãng khai thác

        [Required]
        [JsonPropertyName("Status")]
        public string Status { get; set; } // Loại container

        [Required]
        [JsonPropertyName("CMStatus")]
        public string CMStatus { get; set; } // Trạng thái container trên bãi | S:  Stacking, D: Delivery, I: Incoming , O: Outgoing

        [JsonPropertyName("Thumbnail")]
        public string[] Thumbnail { get; set; } // Danh sách ảnh container
    }
}
