using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ecommerceMSASP.NETCORE.Models;

namespace ecommerceMSASP.NETCORE.Data;

public partial class EcommercedbContext : DbContext
{
    public EcommercedbContext()
    {
    }

    public EcommercedbContext(DbContextOptions<EcommercedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
