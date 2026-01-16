using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Person_contact table
/// </summary>
[Table("person_contact")]
public partial class PersonContact
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Person_id
    /// </summary>
    [Column("person_id")]
    public int? PersonId { get; set; }
    /// <summary>
    /// Contact_type_id
    /// </summary>
    [Column("contact_type_id")]
    public int? ContactTypeId { get; set; }
    /// <summary>
    /// Contact_value
    /// </summary>
    [Column("contact_value")]
    public bool? ContactValue { get; set; }
    /// <summary>
    /// Contact_type_id foreign key
    /// </summary>
    [ForeignKey("ContactTypeId")]
    [InverseProperty("PersonContacts")]
    public virtual ContactType? ContactType { get; set; }
    /// <summary>
    /// Contact's people
    /// </summary>
    [InverseProperty("Contact")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
