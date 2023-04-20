using SpeedyAir.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Model
{
    public class Load
    {
        public Order Order { get; set; }
        public Schedule Schedule { get; set; }
    }
}
