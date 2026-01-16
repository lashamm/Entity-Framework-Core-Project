using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Product_category table
/// </summary>
[Table("product_title")]
public partial class ProductTitle
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Title
    /// </summary>
    [Column("title")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }
    /// <summary>
    /// Product_category_id
    /// </summary>
    [Column("product_category_id")]
    public int? ProductCategoryId { get; set; }
    /// <summary>
    /// Products with this title
    /// </summary>
    [InverseProperty("ProductTitle")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
