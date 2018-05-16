namespace Callway.ConsoleApplication {
    public class ServiceEndpoint {
        public const string CREATE_SESSION = "auth/public/authentication/createsession";
        public const string PROJECT = "account/secure/projects/products/{productname}/views";
        public const string ORIGINATOR = "account/secure/projects/{projectId}/originators";
        public const string SINGLE_SMS = "sms/secure/send/sms/web";
    }
}
