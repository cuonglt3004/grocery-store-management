using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CustomerPoint
    {
        public int ID { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }
        public Order? Order { get; set; }
        public int PointEarn { get; set; }
        public DateTime DateEarn { get; set; }
    }
}
