using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("brand")]
public partial class Brand
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("brand_model_id")]
    public int? BrandModelId { get; set; }

    [ForeignKey("BrandModelId")]
    [InverseProperty("Brands")]
    public virtual Model? BrandModel { get; set; }
}
