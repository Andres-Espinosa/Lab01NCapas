using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("Product")]
[Index("ProductName", Name = "IndexProductName")]
[Index("SupplierId", Name = "IndexProductSupplierId")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string ProductName { get; set; } = null!;

    public int SupplierId { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? UnitPrice { get; set; }

    [StringLength(30)]
    public string? Package { get; set; }

    public bool IsDiscontinued { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [ForeignKey("SupplierId")]
    [InverseProperty("Products")]
    public virtual Supplier Supplier { get; set; } = null!;
}
