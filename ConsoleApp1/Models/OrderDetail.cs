using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Order_details table
/// </summary>
[Table("order_details")]
public partial class OrderDetail
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Customer_order_id
    /// </summary>
    [Column("costumer_order_id")]
    public int? CostumerOrderId { get; set; }
    /// <summary>
    /// Product_id
    /// </summary>
    [Column("product_id")]
    public int? ProductId { get; set; }
    /// <summary>
    /// Price
    /// </summary>
    [Column("price", TypeName = "decimal(4, 2)")]
    public decimal? Price { get; set; }
    /// <summary>
    /// Product_amount
    /// </summary>
    [Column("product_amount")]
    public int? ProductAmount { get; set; }
}
