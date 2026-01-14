using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("customer_order")]
public partial class CustomerOrder
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("branch_id")]
    public int? BranchId { get; set; }

    [ForeignKey("BranchId")]
    [InverseProperty("CustomerOrders")]
    public virtual Branch? Branch { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerOrders")]
    public virtual Customer? Customer { get; set; }
}
