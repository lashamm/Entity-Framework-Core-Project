using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("product_title")]
public partial class ProductTitle
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("product_category_id")]
    public int? ProductCategoryId { get; set; }

    [InverseProperty("ProductTitle")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
