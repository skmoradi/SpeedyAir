using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Data.Model
{
    public class Flight
    {
        public Flight()
        {
            
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Departure { get; set; } // could be a class
        public string Arrival { get; set; } //could be a class
        public int Capacity { get; set; }
    }
}
