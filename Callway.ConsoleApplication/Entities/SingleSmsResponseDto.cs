using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class SingleSmsResponseDto {
        [JsonProperty(PropertyName = "smsRequestId")]
        public long SmsRequestId { get; set; }
    }
}
