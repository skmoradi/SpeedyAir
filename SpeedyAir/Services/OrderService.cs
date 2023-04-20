using Newtonsoft.Json;
using SpeedyAir.Data.Model;
using SpeedyAir.Services.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Services
{
    internal class OrderService : IOrderService
    {

        

        public List<Order> GetOrders()
        {
            List<Order> orderList = new List<Order>();

            string chert = File.ReadAllText(@"files\coding-assigment-orders.json");
            Dictionary<string, Value> Values = JsonConvert.DeserializeObject<Dictionary<string, Value>>(chert);
            foreach (var kvp in Values)
            {
                orderList.Add(new Order()
                {
                    Name = kvp.Key,
                    Priority = Convert.ToInt32(kvp.Key.Substring(kvp.Key.IndexOf("-") + 1)),
                    Destination = kvp.Value.Destination
                });
            }

            return orderList;
        }

        private class Value
        {
            [JsonProperty("destination")]
            public string Destination { get; set; }
        }
    }
}
