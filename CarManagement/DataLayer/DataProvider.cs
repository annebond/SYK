using DataLayer.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataProvider
    {
        CarManagementDbEntities dbmodel = new CarManagementDbEntities();

        public List<Car> QueryAllCars()
        {
            var query = from c in dbmodel.Car
                        select c;

            return query.ToList();
        }

        public bool InsertCar(string name, string type, int? kw, int? miles)
        {
            Guid carId = Guid.NewGuid();

            try
            {
                var newCar = new Car()
                {
                    Id = carId,
                    Name = name,
                    Type = type,
                    Kw = kw,
                    Miles = miles
                };

                dbmodel.Car.Add(newCar);
                dbmodel.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
