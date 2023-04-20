using SpeedyAir.Data.Model;
using SpeedyAir.Repository.IRepository;
using SpeedyAir.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Services
{
    public  class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public IEnumerable<Flight> GetFlights()
        {
           IEnumerable<Flight> flights =  _flightRepository.GetFlights();

            return flights;
        }
    }
}
