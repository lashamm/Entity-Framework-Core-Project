using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Customer_order table
/// </summary>
[Table("customer_order")]
public partial class CustomerOrder
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Customer_id
    /// </summary>
    [Column("customer_id")]
    public int? CustomerId { get; set; }
    /// <summary>
    /// Branch_id
    /// </summary>
    [Column("branch_id")]
    public int? BranchId { get; set; }
    /// <summary>
    /// Branch_id foreign key
    /// </summary>
    [ForeignKey("BranchId")]
    [InverseProperty("CustomerOrders")]
    public virtual Branch? Branch { get; set; }
    /// <summary>
    /// Customer_id foreign key
    /// </summary>
    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerOrders")]
    public virtual Customer? Customer { get; set; }
}
