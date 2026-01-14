using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("order_details")]
public partial class OrderDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("costumer_order_id")]
    public int? CostumerOrderId { get; set; }

    [Column("product_id")]
    public int? ProductId { get; set; }

    [Column("price", TypeName = "decimal(4, 2)")]
    public decimal? Price { get; set; }

    [Column("product_amount")]
    public int? ProductAmount { get; set; }
}
