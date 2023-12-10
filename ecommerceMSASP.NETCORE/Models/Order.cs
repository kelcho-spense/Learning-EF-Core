using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ecommerceMSASP.NETCORE.Models;

[Index("CustomerId", Name = "IX_Orders_CustomerID")]
public partial class Order
{
    [Key]
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime OrderFulfilled { get; set; }

    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Order")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
