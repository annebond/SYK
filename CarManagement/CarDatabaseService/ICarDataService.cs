using SharedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarDatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarDataService" in both code and config file together.
    [ServiceContract]
    public interface ICarDataService
    {
        [OperationContract]
        List<Auto> SelectAllCars();

        [OperationContract]
        bool InsertCar(string name, string type, int? kw, int? miles);
    }
}
