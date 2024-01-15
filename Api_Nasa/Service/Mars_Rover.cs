using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Nasa.Service
{
    internal class Mars_Rover
    {
        public class Camera
        {
            public int id { get; set; }
            public string name { get; set; }
            public int rover_id { get; set; }
            public string full_name { get; set; }
        }

        public class Camera2
        {
            public string name { get; set; }
            public string full_name { get; set; }
        }

        public class Photo
        {
            public int id { get; set; }
            public int sol { get; set; }
            public Camera camera { get; set; }
            public string img_src { get; set; }
            public string earth_date { get; set; }
            public Rover rover { get; set; }
        }

        public class Root
        {
            public List<Photo> photos { get; set; }
        }

        public class Rover
        {
            public int id { get; set; }
            public string name { get; set; }
            public string landing_date { get; set; }
            public string launch_date { get; set; }
            public string status { get; set; }
            public int max_sol { get; set; }
            public string max_date { get; set; }
            public int total_photos { get; set; }
            public List<Camera> cameras { get; set; }
        }


    }
}
