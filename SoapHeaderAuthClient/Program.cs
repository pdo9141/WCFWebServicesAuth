using System;
using SoapHeaderAuthClient.HelloWorldBridge;

namespace SoapHeaderAuthClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HelloWorldSoapClient())
            {
                AuthSoapHd authHeader = new AuthSoapHd
                {
                    UserName = "TestUser",
                    Password = "TestPassword"
                };

                var result = client.AuthTest(authHeader);
                Console.WriteLine("Result: {0}", result);
            }

            Console.ReadLine();
        }
    }
}
