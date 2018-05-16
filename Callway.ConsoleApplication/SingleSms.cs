using System;
using System.Collections.Generic;
using System.Linq;
using Callway.ConsoleApplication.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace Callway.ConsoleApplication {
    public class SingleSms {
        private const string BASE_URL = "https://sorgu.callturk.com.tr";
        private const string PRODUCT = "SMS";

        public readonly SessionDto Session;




        public SingleSms(string username, string password) {
            Session = getToken(username, password);
        }




        private SessionDto getToken(string username, string password) {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(ServiceEndpoint.CREATE_SESSION, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");


            var user = new {
                username,
                password
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);

            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<SessionDto>(response.Content);
        }


        public IList<ProjectViewDto> getProjects() {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(ServiceEndpoint.PROJECT, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");

            request.AddHeader("authenticationTokenId", Session.Token);
            request.AddUrlSegment("productname", PRODUCT);

            var response = client.Execute(request);
            var deserializeObject = JsonConvert.DeserializeObject<ProjectDto>(response.Content);


            return deserializeObject.ProjectViews;
        }


        public IList<ContractOriginatorDto> getOriginators(long projectId) {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(ServiceEndpoint.ORIGINATOR, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");

            request.AddHeader("authenticationTokenId", Session.Token);
            request.AddUrlSegment("projectId", projectId);

            var response = client.Execute(request);
            var deserializeObject = JsonConvert.DeserializeObject<ContractOriginatorWrapperDto>(response.Content);


            return deserializeObject.ContractOriginators
                .Where(t => t.GetOriginatorApprovalStatus() == OriginatorApprovalStatus.APPROVED)
                .ToList();
        }


        public long sendSms(SingleSmsRequestDto model) {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(ServiceEndpoint.SINGLE_SMS, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");

            request.AddHeader("authenticationTokenId", Session.Token);
            request.AddParameter("application/json", JsonConvert.SerializeObject(model), ParameterType.RequestBody);

            var response = client.Execute(request);
            var deserializeObject = JsonConvert.DeserializeObject<SingleSmsResponseDto>(response.Content);


            return deserializeObject.SmsRequestId;
        }
    }
}
