using System;
using System.ServiceModel;
using System.ServiceModel.Security;
using WcfAuthClient.WcfAuthBridge;

namespace WcfAuthClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var client = new Service1Client())
                {
                    client.ClientCredentials.UserName.UserName = "pdo9141@gmail.com";
                    client.ClientCredentials.UserName.Password = "P##@6#####3";

                    var result = client.SayHello();
                    Console.WriteLine("Result: {0}", result);

                    var result1 = client.ReportSales();
                    Console.WriteLine("Result1: {0}", result1);
                }
            }
            catch (MessageSecurityException mse)
            {
                Console.WriteLine(mse.Message);
            }
            catch (FaultException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
