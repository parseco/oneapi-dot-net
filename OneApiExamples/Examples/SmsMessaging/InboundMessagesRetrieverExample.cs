using System;
using OneApi.Config;
using OneApi.Client.Impl;
using OneApi.Model;
using OneApi.Listeners;

namespace OneApi.Examples.SmsMessaging
{
   
	public class InboundMessagesRetrieverExample
	{
        private static string username = "FILL USERNAME HERE !!!";
        private static string password = "FILL PASSWORD HERE !!!";

        public static void Execute()
		{
            Configuration configuration = new Configuration(username, password);      
			SMSClient smsClient = new SMSClient(configuration);

            smsClient.SmsMessagingClient.AddPullInboundMessageListener(new InboundMessageListener((smsMessageList, e) =>
            {
                //Handle pulled Inbound Messages
                if (e == null)
                {
                    Console.WriteLine("Inbound Messages " + smsMessageList);
                }
                else
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }));

            //Stop the Inbound Messages retriever and release listeners
            //smsClient.SmsMessagingClient.RemovePullInboundMessageListeners();
        } 
    }
}