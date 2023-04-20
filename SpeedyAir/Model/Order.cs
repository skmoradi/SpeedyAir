using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Data.Model
{
    public class Order
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public int Priority { get; set; }
    }
}
