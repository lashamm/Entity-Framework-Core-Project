using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Customer table
/// </summary>
[Table("customer")]
public partial class Customer
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Person_id
    /// </summary>
    [Column("person_id")]
    public int? PersonId { get; set; }
    /// <summary>
    /// Card_number
    /// </summary>
    [Column("card_number")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CardNumber { get; set; }
    /// <summary>
    /// Customer
    /// </summary>
    [InverseProperty("Customer")]
    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
    /// <summary>
    /// Person_id foreign key
    /// </summary>
    [ForeignKey("PersonId")]
    [InverseProperty("Customers")]
    public virtual Person? Person { get; set; }
}
