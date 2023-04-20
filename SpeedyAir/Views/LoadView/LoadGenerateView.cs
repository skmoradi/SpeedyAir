using SpeedyAir.Data.Model;
using SpeedyAir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Views.LoadView
{
    public class LoadGenerateView
    {
        private readonly List<Load> loads;
        private readonly List<Order> ordersOnHold;

        public LoadGenerateView(List<Load> loads, List<Order> ordersOnHold)
        {
            this.loads = loads;
            this.ordersOnHold = ordersOnHold;
        }

        public void Show()
        {
            Console.Clear();

            string message;
            foreach (Load load in loads)
            {
                message = string.Format("order: {0}, flightNumber: {1}, departure: {2}, arrival: {3}, day: {4}",
                    load.Order.Name,
                    load.Schedule.Flight.Code,
                    load.Schedule.Flight.Departure,
                    load.Schedule.Flight.Arrival,
                    load.Schedule.DateNumber);

                Console.WriteLine(message);
            }

            if (ordersOnHold.Count > 0)
            {
                Console.WriteLine("List of Not scheduled Orders:");
                foreach (Order order in ordersOnHold)
                {
                    message = string.Format("order: {0}, flightNumber not scheduled", order.Name);
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
