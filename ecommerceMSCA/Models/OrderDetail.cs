using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ecommerceDemo.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; } //foreign key which if ommited ef core will create it anyway as  a shadow property
        public int OrderId { get; set; } //foreign key which if ommited ef core will create it anyway as  a shadow property
        public Order Order { get; set; } = null!; //navigation property : one order per order detail(one to one)
        public Product Product { get; set; } = null!; //navigation property : one product per order detail(one to one)

    }
}