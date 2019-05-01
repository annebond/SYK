using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SharedType
{
    [DataContract]
    public class Auto
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int? Kw { get; set; }
        [DataMember]
        public int? Miles { get; set; }

        public Auto(Guid id, string name, string type, int? kw, int? miles)
        {
            Id = id;
            Name = name;
            Type = type;
            Kw = kw;
            Miles = miles;
        }

        


    }
}
