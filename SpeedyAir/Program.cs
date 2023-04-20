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
            while (true)
            {
                Console.WriteLine("UserStory1:<1>\nUserStory2:<2>\nExist:<Any Key>");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    ScheduleController scheduleController = new ScheduleController(new ScheduleService());
                    scheduleController.ScheduleByFlight();
                }
                else if (result == "2")
                {
                    GenerateLoadController generateLoadController = new GenerateLoadController(new OrderService(), new ScheduleService());
                    generateLoadController.GenerateLoad();
                }
                else
                {
                    break;
                }
            }
        }
    }
}