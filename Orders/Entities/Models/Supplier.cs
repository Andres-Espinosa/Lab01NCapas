using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("Supplier")]
[Index("Country", Name = "IndexSupplierCountry")]
[Index("CompanyName", Name = "IndexSupplierName")]
public partial class Supplier
{
    [Key]
    public int Id { get; set; }

    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [StringLength(50)]
    public string? ContactName { get; set; }

    [StringLength(40)]
    public string? ContactTitle { get; set; }

    [StringLength(40)]
    public string? City { get; set; }

    [StringLength(40)]
    public string? Country { get; set; }

    [StringLength(30)]
    public string? Phone { get; set; }

    [StringLength(30)]
    public string? Fax { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
