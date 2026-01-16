using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Contact_type table
/// </summary>
[Table("contact_type")]
public partial class ContactType
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
    /// Contact_type
    /// </summary>
    [InverseProperty("ContactType")]
    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();
}
