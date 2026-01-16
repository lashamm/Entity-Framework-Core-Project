using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Product_category table
/// </summary>
[Table("product_category")]
public partial class ProductCategory
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }
}
