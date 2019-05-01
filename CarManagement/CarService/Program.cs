using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(KwConvertService));
            host.Open();
            Console.WriteLine("KwConvertService started...");
            Console.ReadLine();
        }
    }
}
