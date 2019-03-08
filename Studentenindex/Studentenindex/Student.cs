using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studentenindex
{
    public class Student
    {
       

        public string Name { get; set; }
        public int Geburtsjahr { get; set; }
        public string Geschlecht { get; set; }

        public int Matrikelnr { get; set; }
        public int Studiengang { get; set; }
    }
}