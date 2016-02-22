using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(PersonService.Service));
            Console.WriteLine("Service is running...");
            host.Open();
            Console.WriteLine("press any key to close service");
            Console.ReadKey();
            host.Close();
        }
    }
}
