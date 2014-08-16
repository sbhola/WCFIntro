using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcConsumer.CalcService;


namespace CalcConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new CalcServiceClient())
            //{
            //    var complexNum = client.CreateComplexNumber(4, 5);
            //    Console.WriteLine(client.GetRealPart(complexNum));

            //    Console.WriteLine(client.GetImagPart(complexNum));

            //    Console.WriteLine(client.GetData(100));

            //}

            using (var secureClient = new CalcServiceClient("WSHttpBinding_ICalcService"))
            {
                Console.WriteLine("Communicate with secure endpoint.");

                var complexNum = secureClient.CreateComplexNumber(4, 5);
                Console.WriteLine(secureClient.GetRealPart(complexNum));

                Console.WriteLine(secureClient.GetImagPart(complexNum));

                Console.WriteLine(secureClient.GetData(100));
            }
        }
    }
}
