using System.Collections.Generic;
using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class SingleSmsRequestDto {
        [JsonProperty(PropertyName = "channelName")]
        public string ChannelName { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "clientIdentifier")]
        public string ClientIdentifier { get; set; }

        public bool ShouldSerializeClientIdentifier() {
            return !string.IsNullOrEmpty(ClientIdentifier);
        }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        public bool ShouldSerializeDescription() {
            return !string.IsNullOrEmpty(Description);
        }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "inUnicode")]
        public bool InUnicode { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }

        public bool ShouldSerializeLanguageCode() {
            return !string.IsNullOrEmpty(LanguageCode);
        }


        [JsonProperty(PropertyName = "phoneNumber")]
        public IList<string> PhoneNumbers { get; set; }


        [JsonProperty(PropertyName = "projectId")]
        public long ProjectId { get; set; }


        [JsonProperty(PropertyName = "senderValue")]
        public string SenderValue { get; set; }


        [JsonProperty(PropertyName = "smsText")]
        public string SmsText { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "allowDuplicate")]
        public bool AllowDuplicate { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "smsSchedule")]
        public SmsScheduleDto Schedule { get; set; }

        public bool ShouldSerializeSchedule() {
            return Schedule != null;
        }




        public SingleSmsRequestDto() {
            PhoneNumbers = new List<string>();
        }
    }
}
