using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("person_contact")]
public partial class PersonContact
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("person_id")]
    public int? PersonId { get; set; }

    [Column("contact_type_id")]
    public int? ContactTypeId { get; set; }

    [Column("contact_value")]
    public bool? ContactValue { get; set; }

    [ForeignKey("ContactTypeId")]
    [InverseProperty("PersonContacts")]
    public virtual ContactType? ContactType { get; set; }

    [InverseProperty("Contact")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
