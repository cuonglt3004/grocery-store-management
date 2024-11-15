using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public float TotalAmount { get; set; }
        public int ShipingType { get; set; }
        public DateTime PickupTime { get; set; }
        public string? Note { get; set; }
        public string? InventoryAddress { get; set; }
        public string? ShippingAddress { get; set; }
        public string? ShippingPhoneNumber { get; set; }
    }
}
