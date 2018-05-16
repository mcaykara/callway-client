using System;
using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class ContractOriginatorDto {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }


        [JsonProperty(PropertyName = "contractId")]
        public long ContractId { get; set; }


        [JsonProperty(PropertyName = "originatorValue")]
        public string OriginatorValue { get; set; }


        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }


        [JsonProperty(PropertyName = "creatorId")]
        public long CreatorId { get; set; }


        [JsonProperty(PropertyName = "lastModifiedDate")]
        public string LastModifiedDate { get; set; }


        [JsonProperty(PropertyName = "originatorApprovalStatus")]
        public string OriginatorApprovalStatus { get; set; }


        public OriginatorApprovalStatus GetOriginatorApprovalStatus() {
            return (OriginatorApprovalStatus)Enum.Parse(typeof(OriginatorApprovalStatus), OriginatorApprovalStatus);
        }
    }
}
