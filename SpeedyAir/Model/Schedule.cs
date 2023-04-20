using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Data.Model
{
    public class Schedule
    {
        public int DateNumber { get; set; }
        public Flight Flight { get; set; }
    }
}
