using System;
using System.Linq;
using Callway.ConsoleApplication.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace Callway.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            var channelName = "API_CALLWAY";
            var projectName = "test projesi";
            var originatorName = "DENEME";

            var username = "kullanıcı_adı";
            var password = "parola";


            var phoneNumbers = new[] {
                "5996667788",
                "5996667789",
                "5996667790"
            };



            var singleSms = new SingleSms(username, password);

            var projects = singleSms.getProjects();
            var project = projects.FirstOrDefault(p => p.Name == projectName);

            if (project == null) {
                throw new Exception("Proje bulunamadı");
            }


            var originators = singleSms.getOriginators(project.Id);
            var originator = originators.FirstOrDefault(o => o.OriginatorValue == originatorName);

            if (originator == null) {
                throw new Exception("Originator bulunamadı");
            }



            var singleSmsDto = new SingleSmsRequestDto {
                ProjectId = project.Id,
                SenderValue = originator.OriginatorValue,
                PhoneNumbers = phoneNumbers,
                ChannelName = channelName,
                SmsText = "deneme mesajıdır, dikkate almayınız",

                AllowDuplicate = false,                             // opsiyonel
                ClientIdentifier = "track number 1",                // opsiyonel
                Description = "description",                        // opsiyonel
                InUnicode = true,                                   // opsiyonel
                LanguageCode = "TR",                                // opsiyonel
                Schedule = new SmsScheduleDto {                     // opsiyonel
                    PlannedDateTime = new DateTime(2018, 5, 16, 10, 24, 00).ToString("yyyy-MM-dd HH:mm:ss")   // opsiyonel
                }
            };

            long smsRequestId = -1L;


            try {
                smsRequestId = singleSms.sendSms(singleSmsDto);
            } catch (Exception e) {
                throw new Exception("Sms gönderirken hata oluştu");
            }


            Console.WriteLine($"Gönderim işlemi başarıyla sonuçlanmıştır, işlem numarası {smsRequestId}");
        }
    }
}
