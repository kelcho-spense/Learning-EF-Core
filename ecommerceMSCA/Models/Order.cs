using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceDemo.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFulfilled { get; set; }
        public int CustomerID { get; set; } //foreign key which if ommited ef core will create it anyway as  a shadow property
        public Customer Customer { get; set; } = null!; //navigation property : one custmer per order(one to one)
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!; //navigation property : one to many
    }
}