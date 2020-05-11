using System;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;
using Microsoft.Azure.NotificationHubs.Messaging;

namespace NotificationHub
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Grab 10% Cashback on your Dish TV Recharges";
            string tag = "users";
            var alert = "{\"aps\":{\"alert\":\"" + message +"}}";
            SendNotificationAsync(alert, tag).Wait();
        }

        private static async Task SendNotificationAsync(string alert, string tag)
        {
            NotificationHubClient Hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://vishalnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=jZZF8a/J08TUXMxI/4ML5LhzIveVVInr7PEehL6FTLE", "vishalnotificationhub");

            NotificationOutcome toast = await Hub.SendAppleNativeNotificationAsync(alert, tag);

        }
    }
}
