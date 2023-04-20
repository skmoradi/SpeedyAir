using SpeedyAir.Data.Model;
using SpeedyAir.Services;
using SpeedyAir.Services.IServices;
using SpeedyAir.Views.LoadView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Controllers
{
    internal class GenerateLoadController
    {
        private readonly IOrderService _orderService;
        private readonly IScheduleService _scheduleService;

        public GenerateLoadController(IOrderService orderService, IScheduleService scheduleService)
        {
            _orderService = orderService;
            _scheduleService = scheduleService;
        }

        public void GenerateLoad()
        {
            List<Order> orders = _orderService.GetOrders();
            List<Schedule> schedules = _scheduleService.GetSchedules();
            
            LoadGenerator loadGenerator = new LoadGenerator();
            var loads = loadGenerator.GenerateFlightItineraries(orders, schedules);

            var missingOrders = orders.Where(o => !loads.Any(l => l.Order.Name == o.Name)).ToList();

            LoadGenerateView loadGenerateView = new LoadGenerateView(loads, missingOrders);
            loadGenerateView.Show();
        }

    }
}
