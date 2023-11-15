using System.Text.Json.Serialization;

namespace ApiContainer.Common
{
    public class ResponseApi<T>
    {
        [JsonPropertyName("Success")]
        public bool Success { get; set; }
        [JsonPropertyName("Message")]
        public string Message { get; set; }
        [JsonPropertyName("Data")]
        public T? Data { get; set; }

        public ResponseApi(bool success, string message, T? data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
