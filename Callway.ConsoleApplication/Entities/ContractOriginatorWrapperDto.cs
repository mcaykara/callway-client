using System.Collections.Generic;
using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class ContractOriginatorWrapperDto {
        [JsonProperty(PropertyName = "contractOriginator")]
        public IList<ContractOriginatorDto> ContractOriginators { get; set; }




        public ContractOriginatorWrapperDto() {
            ContractOriginators = new List<ContractOriginatorDto>();
        }
    }
}
