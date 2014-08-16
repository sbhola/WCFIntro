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

                var complexNum1 = secureClient.CreateComplexNumber(4, 5);
                Console.WriteLine(secureClient.GetRealPart(complexNum1));

                Console.WriteLine(secureClient.GetImagPart(complexNum1));

                Console.WriteLine(secureClient.GetData(100));

                var complexNum2 = secureClient.CreateComplexNumber(7, 8);
                Console.WriteLine(secureClient.GetRealPart(complexNum2));

                Console.WriteLine(secureClient.GetImagPart(complexNum2));

                secureClient.AddToList(complexNum1);
                secureClient.AddToList(complexNum2);

                var listCompNums = secureClient.GetComplexNumList();


            }
        }
    }
}
