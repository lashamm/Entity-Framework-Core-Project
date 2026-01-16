using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// City table
/// </summary>
[Table("city")]
public partial class City
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
    /// Street_id
    /// </summary>
    [Column("street_id")]
    public int? StreetId { get; set; }
    /// <summary>
    /// City
    /// </summary>
    [InverseProperty("City")]
    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
    /// <summary>
    /// Street_id foreign key
    /// </summary>
    [ForeignKey("StreetId")]
    [InverseProperty("Cities")]
    public virtual Street? Street { get; set; }
}
