using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("customer")]
public partial class Customer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("person_id")]
    public int? PersonId { get; set; }

    [Column("card_number")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CardNumber { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    [ForeignKey("PersonId")]
    [InverseProperty("Customers")]
    public virtual Person? Person { get; set; }
}
