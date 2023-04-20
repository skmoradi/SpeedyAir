using SpeedyAir.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Views.ScheduleView
{
    class ScheduleByFlightView
    {
        private readonly List<Schedule> _schedules;

        public ScheduleByFlightView(List<Schedule> schedules)
        {
            _schedules = schedules;
        }

        public void Show()
        {
            Console.Clear();

            string message;

            _schedules.ForEach( (schedule) =>
            {
                message = string.Format("flightNumber: {0}, departure: {1}, arrival: {2}, day: {3}",
                    schedule.Flight.Code,
                    schedule.Flight.Departure,
                    schedule.Flight.Arrival,
                    schedule.DateNumber);
                
                Console.WriteLine(message);
            });

            Console.ReadLine();
        }
    }
}
