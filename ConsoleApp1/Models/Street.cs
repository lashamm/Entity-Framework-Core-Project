using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Street table
/// </summary>
[Table("street")]
public partial class Street
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
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }
    /// <summary>
    /// Street
    /// </summary>
    [InverseProperty("Street")]
    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
