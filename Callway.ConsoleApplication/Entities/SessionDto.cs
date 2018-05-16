using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class SessionDto {
        [JsonProperty("token")]
        public string Token { get; set; }


        [JsonProperty("username")]
        public string Username { get; set; }


        [JsonProperty("fullName")]
        public string Fullname { get; set; }
    }
}
