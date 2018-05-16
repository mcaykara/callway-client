using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class SmsScheduleDto {
        /// <summary>
        /// Opsiyonel
        /// Örnek: 2018-05-17 19:50:00
        /// </summary>
        [JsonProperty(PropertyName = "plannedDateTime")]
        public string PlannedDateTime { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "startHour")]
        public int StartHour { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "endHour")]
        public int EndHour { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "messageCountPerInterval")]
        public int MessageCountPerInterval { get; set; }


        /// <summary>
        /// Opsiyonel
        /// </summary>
        [JsonProperty(PropertyName = "periodIntervalInMinutes")]
        public int PeriodIntervalInMinutes { get; set; }
    }
}
