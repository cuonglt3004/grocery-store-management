using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
   public class Category
    {
        [Key]
        public int ID { get; set; }

        public string? Description { get; set; }

        public DateTime CreateAt { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
