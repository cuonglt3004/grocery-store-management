using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public float Price { get; set; }

        public int StockQuantity { get; set; }

        [ForeignKey(nameof(Category))]
        public int CagtegoryID { get; set; }

        public Category? Category { get; set; }

        public DateTime CreateAt { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
