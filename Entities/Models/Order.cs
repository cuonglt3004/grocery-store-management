using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }

        public Customer? Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public int Status { get; set; }

        public float TotalAmount { get; set; }

        public int ShipingType { get; set; }

        public DateTime PickupTime { get; set; }

        public string? Note { get; set; }

        public string? InventoryAddress { get; set; }

        [Required(ErrorMessage = "Shiping Address is required")]
        public string? ShippingAddress { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(12, ErrorMessage = "Phone Number can't be longer than 12 characters")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string? ShippingPhoneNumber { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        public ICollection<CustomerPoint>? CustomerPoints { get; set; }


    }
}
