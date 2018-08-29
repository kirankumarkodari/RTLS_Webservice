using Microsoft.Azure.NotificationHubs;

namespace WebServiceRest
{
    public class Notifications
    {
        public static Notifications Instance = new Notifications();

        public NotificationHubClient Hub { get; set; }

        private Notifications()
        {
            Hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://tatarakshak.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=isX4AOM/VKYzQZNj6Xp+uOmUrU/LttTfvmkxgm7bmcY=",
                                                                         "tatarakshakhub");
        }
    }
}