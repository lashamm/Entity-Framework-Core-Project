using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("product")]
public partial class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("product_title_id")]
    public int? ProductTitleId { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Price { get; set; }

    [Column("comment")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("brand_id")]
    public int? BrandId { get; set; }

    [ForeignKey("ProductTitleId")]
    [InverseProperty("Products")]
    public virtual ProductTitle? ProductTitle { get; set; }
}
