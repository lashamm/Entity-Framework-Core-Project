using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("city")]
public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("street_id")]
    public int? StreetId { get; set; }

    [InverseProperty("City")]
    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    [ForeignKey("StreetId")]
    [InverseProperty("Cities")]
    public virtual Street? Street { get; set; }
}
