using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("contact_type")]
public partial class ContactType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [InverseProperty("ContactType")]
    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();
}
