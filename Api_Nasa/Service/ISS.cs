using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Nasa.Service
{
    internal class ISS
    {
        public class IssPosition
        {
            public string longitude { get; set; }
            public string latitude { get; set; }
        }

        public class Root
        {
            public string message { get; set; }
            public IssPosition iss_position { get; set; }
            public int timestamp { get; set; }
        }

    }
}
