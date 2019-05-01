using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KwConvertService" in both code and config file together.
    public class KwConvertService : IKwConvertService
    {  
        public int PsToKw(int ps)
        {
            return (int) (ps * 0.73);
        }
    }
}
