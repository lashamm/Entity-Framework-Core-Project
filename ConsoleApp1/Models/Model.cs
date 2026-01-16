using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Model table
/// </summary>
[Table("model")]
public partial class Model
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
    /// Brand_model
    /// </summary>
    [InverseProperty("BrandModel")]
    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
}
