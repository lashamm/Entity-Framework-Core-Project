using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;
/// <summary>
/// Branch table
/// </summary>
[Table("branch")]
public partial class Branch
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
    /// City_id
    /// </summary>
    [Column("city_id")]
    public int? CityId { get; set; }
    /// <summary>
    /// City_id foreign key
    /// </summary>
    [ForeignKey("CityId")]
    [InverseProperty("Branches")]
    public virtual City? City { get; set; }

    [InverseProperty("Branch")]
    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
}
