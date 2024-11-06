using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }

        public Product? Product { get; set; }
        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }
        public Order? Order { get; set; }

        public int Quantity { get; set; }

        public float UnitPrice { get; set; }
    }
}
