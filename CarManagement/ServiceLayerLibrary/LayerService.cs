using MQHandler2;
using SharedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerLibrary
{
    public class LayerService
    {
        MQHandling<Auto> mq = new MQHandling<Auto>("entries");
        SR_CarService.KwConvertServiceClient client2 = new SR_CarService.KwConvertServiceClient();
        //connectedService.<ServiceName>Client client1 = new connectedService.<ServiceName>Client();
        SR_CarDatabaseService.CarDataServiceClient client1 = new SR_CarDatabaseService.CarDataServiceClient();

        public LayerService()
        {
            Task.Factory.StartNew(InsertToDb);   
        }

        public void InsertToDb()
        {
            while (true)
            {
                Auto a = mq.Read();
                int kw = client2.PsToKw((int)a.Kw);
                client1.InsertCar(a.Name, a.Type, kw, a.Miles);
            }

        }

        public List<Auto> QueryAll()
        {
            List<Auto> temp = new List<Auto>();

            foreach (var item in client1.SelectAllCars())
            {
                temp.Add(new Auto(item.Id, item.Name, item.Type, item.Kw, item.Miles));
            }

            return temp;
        }

    }

}
