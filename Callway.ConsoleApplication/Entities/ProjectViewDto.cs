using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class ProjectViewDto {
        [JsonProperty(PropertyName = "projectId")]
        public long Id { get; set; }


        [JsonProperty(PropertyName = "contractId")]
        public long? ContractId { get; set; }


        [JsonProperty(PropertyName = "projectName")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "projectType")]
        public string ProjectType { get; set; }
    }
}
