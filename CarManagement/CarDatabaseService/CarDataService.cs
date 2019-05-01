using DataLayer;
using SharedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarDatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarDataService" in both code and config file together.
    public class CarDataService : ICarDataService
    {
        DataProvider dataProvider = new DataProvider();

        public bool InsertCar(string name, string type, int? kw, int? miles)
        {
            return dataProvider.InsertCar(name, type, kw, miles);
        }

        public List<Auto> SelectAllCars()
        {
            List<Auto> temp = new List<Auto>();

            foreach (var item in dataProvider.QueryAllCars())
            {
                temp.Add(new Auto(item.Id, item.Name, item.Type, item.Kw, item.Miles));
            }

            return temp;
        }
    }
}
