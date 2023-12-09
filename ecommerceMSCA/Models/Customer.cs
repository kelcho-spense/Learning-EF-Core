using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ecommerceMSCA.Models;

namespace ecommerceDemo.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = String.Empty;
        [MaxLength(50)]
        public string? Address { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public ICollection<Order> Orders { get; set; } = null!; //navigation property : one to many
    }
}
