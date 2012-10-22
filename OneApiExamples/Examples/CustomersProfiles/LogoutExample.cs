﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OneApi.Config;
using OneApi.Client.Impl;
using OneApi.Model;

namespace OneApi.Examples.CustomerProfiles
{
    class LogoutExample 
    {
        private static string username = "FILL USERNAME HERE !!!";
        private static string password = "FILL PASSWORD HERE !!!";

        public static void Execute()
        {
            Configuration configuration = new Configuration(username, password);    
            SMSClient smsClient = new SMSClient(configuration);

            smsClient.CustomerProfileClient.Logout();
            
            Console.WriteLine("Logout success.");
        }
    }
}
