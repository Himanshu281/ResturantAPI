using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.models
{
    public class OrderMaster
    {
        [Key]
        public long MyProperty { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string OrderName { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } // Foreign key

        [Column(TypeName = "nvarchar(10)")]
        public string PaymentMethod { get; set; }

        public decimal GrandTotal { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
