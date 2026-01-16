using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;
/// <summary>
/// Product table
/// </summary>
[Table("product")]
public partial class Product
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Product_title_id
    /// </summary>
    [Column("product_title_id")]
    public int? ProductTitleId { get; set; }
    /// <summary>
    /// Price
    /// </summary>
    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Price { get; set; }
    /// <summary>
    /// Comment
    /// </summary>
    [Column("comment")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Comment { get; set; }
    /// <summary>
    /// Brand_id
    /// </summary>
    [Column("brand_id")]
    public int? BrandId { get; set; }
    /// <summary>
    /// Product_title_id foreign key
    /// </summary>
    [ForeignKey("ProductTitleId")]
    [InverseProperty("Products")]
    public virtual ProductTitle? ProductTitle { get; set; }
}
