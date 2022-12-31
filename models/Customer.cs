using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantAPI.models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string CustomerName { get; set; }
    }
}
