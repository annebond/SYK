using MQHandler2;
using SharedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MQHandling<Auto> handler = new MQHandling<Auto>("entries");

            Random rnd = new Random();
            Console.WriteLine("Send Cars with MSMQ");

            while (true)
            {
                Guid guid = Guid.NewGuid();
                handler.Send(new Auto(guid, "Porsche", "GT2" , rnd.Next(200,500), rnd.Next(10000,100000)));
                Thread.Sleep(2000);
            }
        }
    }
}
