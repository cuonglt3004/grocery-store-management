using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PromotionDTO
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
        public float DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
