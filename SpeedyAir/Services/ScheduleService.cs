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
    public  class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository = null)
        {
            if (scheduleRepository == null)
            {
                _scheduleRepository = new ScheduleRepository();
            }
            else
            {
                _scheduleRepository = scheduleRepository;
            }
        }

        public List<Schedule> GetSchedules()
        {
            var schedules = _scheduleRepository.GetSchedules().ToList();
            return schedules;
        }
    }
}
