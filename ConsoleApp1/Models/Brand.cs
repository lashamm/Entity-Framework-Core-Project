using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// brand table
/// </summary>
[Table("brand")]
public partial class Brand
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
    /// <summary>
    /// Brand_model_id
    /// </summary>
    [Column("brand_model_id")]
    public int? BrandModelId { get; set; }
    /// <summary>
    /// Brand_model_id foreign key
    /// </summary>
    [ForeignKey("BrandModelId")]
    [InverseProperty("Brands")]
    public virtual Model? BrandModel { get; set; }
}
