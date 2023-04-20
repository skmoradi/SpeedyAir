using SpeedyAir.Controllers;
using SpeedyAir.Services;
using SpeedyAir.Views.LoadView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateLoadController generateLoadController = new GenerateLoadController(new OrderService(),  new ScheduleService());
            generateLoadController.GenerateLoad();
        }
    }
}
