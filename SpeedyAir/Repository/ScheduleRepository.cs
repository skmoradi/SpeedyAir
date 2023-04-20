using SpeedyAir.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Repository.IRepository
{
    public class ScheduleRepository : IScheduleRepository
    {
        public ScheduleRepository()
        {
            
        }

        public IList<Schedule> GetSchedules()
        {
            List<Schedule> schedules = new  List<Schedule>
            {
                new Schedule()
                {
                    DateNumber = 1,
                    Flight = new Flight() { Id = 1, Code = "1", Departure = "YUL", Arrival = "YYZ", Capacity = 20}
                },
                new Schedule()
                {
                    DateNumber = 1,
                    Flight = new Flight() {Id = 2, Code = "2", Departure = "YUL", Arrival = "YYC", Capacity = 20}
                },
                new Schedule()
                {
                    DateNumber = 1,
                    Flight = new Flight() {Id = 3, Code = "3", Departure = "YUL", Arrival = "YVR", Capacity = 20}
                },
                new Schedule()
                {
                    DateNumber = 2,
                    Flight = new Flight() {Id = 4, Code = "4", Departure = "YUL", Arrival = "YYZ", Capacity = 20}
                },
                new Schedule()
                {
                    DateNumber = 2,
                    Flight = new Flight() {Id = 5, Code = "5", Departure = "YUL", Arrival = "YYC", Capacity = 20}
                },
                new Schedule()
                {
                    DateNumber = 2,
                    Flight = new Flight() {Id = 6, Code = "6", Departure = "YUL", Arrival = "YVR", Capacity = 20}
                }
            };

            return schedules;
        }
    }
}
