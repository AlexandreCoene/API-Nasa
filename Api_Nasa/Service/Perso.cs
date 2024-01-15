using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Nasa.Service
{
    internal class Perso
    {
        public class Person
        {
            public string name { get; set; }
            public string craft { get; set; }
        }

        public class Root
        {
            public string message { get; set; }
            public List<Person> people { get; set; }
            public int number { get; set; }
        }

    }
}
