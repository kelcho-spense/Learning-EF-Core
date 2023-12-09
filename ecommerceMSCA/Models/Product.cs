using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceDemo.Models
{
    public class Product
    {
        [Key] // This is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // This is an auto-incrementing field
        public int Id { get; set; }
        public string Name { get; set; } = null!; // null-forgiving operator

        [Column(TypeName = "decimal(6,2)")] // 2 decimal places, 6 digits
        public decimal Price { get; set; }
    }
}
