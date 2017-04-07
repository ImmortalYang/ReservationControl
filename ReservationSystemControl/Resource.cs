using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemControl
{
    /// <summary>
    /// Entity class for resource
    /// </summary>
    public class Resource
    {
        private static int maxID = 0;
        public int ResourceID { get; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }

        public Resource(string name, double unitPrice, string description = "")
        {
            ResourceID = Resource.maxID++;
            Name = name;
            UnitPrice = unitPrice;
            Description = description;
        }
    }
}
