using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerPointDTO
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int PointEarn { get; set; }
        public DateTime DateEarn { get; set; }
    }
}
