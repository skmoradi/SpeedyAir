using SpeedyAir.Data.Model;
using SpeedyAir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Services
{
    public class LoadGenerator
    {
        public LoadGenerator() { }

        public List<Load> GenerateFlightItineraries(List<Order> orders, List<Schedule> schedules)
        {
            List<Load> loads = new List<Load>();
            
            foreach (Order order in orders)
            {
                Flight flight =  schedules.Select(s => s.Flight).FirstOrDefault(f => f.Arrival == order.Destination && !isFull(loads, f));
                
                if (flight != null)
                {
                    Schedule schedule = schedules.First(s => s.Flight.Id == flight.Id); // this is not a good in all scenarios. must change
                    loads.Add(new Load { Order = order, Schedule = schedule });
                }
            }

            return loads;
        }

        private bool isFull(List<Load> loads, Flight flight)
        {
            int count = loads.Count(l => l.Schedule.Flight.Id == flight.Id);

            if (loads.Count(l => l.Schedule.Flight.Id == flight.Id) == flight.Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
