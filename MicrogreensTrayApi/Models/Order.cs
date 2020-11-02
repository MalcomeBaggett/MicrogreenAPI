using System;
using MicrogreensTrayApi.Models;
namespace MicrogreensTrayApi.Models
{
    public class Orders
    {
        public bool IsPreordered { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public Customer CustomerInformation { get; set; }

    }
}