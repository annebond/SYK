using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarDatabaseService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CarDataService));
            host.Open();
            Console.WriteLine("CarDatabaseService started...");
            Console.ReadLine();
        }
    }
}
