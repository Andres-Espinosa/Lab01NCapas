using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("Customer")]
[Index("LastName", "FirstName", Name = "IndexCustomerName")]
public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(40)]
    public string FirstName { get; set; } = null!;

    [StringLength(40)]
    public string LastName { get; set; } = null!;

    [StringLength(40)]
    public string? City { get; set; }

    [StringLength(40)]
    public string? Country { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
