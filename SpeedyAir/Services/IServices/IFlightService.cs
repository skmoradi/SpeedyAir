using SpeedyAir.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Services.IServices
{
    internal interface IFlightService
    {
        IEnumerable<Flight> GetFlights();
    }
}
