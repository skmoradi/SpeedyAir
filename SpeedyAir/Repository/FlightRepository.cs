using SpeedyAir.Data.Model;
using SpeedyAir.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Repository
{
    public class FlightRepository : IFlightRepository
    {
        public FlightRepository() { }
        
        public IEnumerable<Flight> GetFlights()
        {
            List<Flight> flights = new List<Flight>()
            {
                new Flight() {Id = 1, Code = "1", Departure = "YUL", Arrival = "YYZ", Capacity = 20},
                new Flight() {Id = 2, Code = "2", Departure = "YUL", Arrival = "YYC", Capacity = 20},
                new Flight() {Id = 3, Code = "3", Departure = "YUL", Arrival = "YVR", Capacity = 20},

                new Flight() {Id = 4, Code = "4", Departure = "YUL", Arrival = "YYZ", Capacity = 20},
                new Flight() {Id = 5, Code = "5", Departure = "YUL", Arrival = "YYC", Capacity = 20},
                new Flight() {Id = 6, Code = "6", Departure = "YUL", Arrival = "YVR", Capacity = 20}
            };

            return flights;
        }

    }
}
