using SpeedyAir.Services.IServices;
using SpeedyAir.Views.ScheduleView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Controllers
{
    class ScheduleController
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        public void ScheduleByFlight()
        {
            var schedules = _scheduleService.GetSchedules();

            ScheduleByFlightView scheduleByFlightView = new ScheduleByFlightView(schedules);
            scheduleByFlightView.Show();
        }
    }
}