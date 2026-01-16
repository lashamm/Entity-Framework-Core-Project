using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

/// <summary>
/// Person table
/// </summary>
[Table("person")]
public partial class Person
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
    /// Surname
    /// </summary>
    [Column("surname")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Surname { get; set; }
    /// <summary>
    /// Birth_date
    /// </summary>
    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }
    /// <summary>
    /// Contact_id
    /// </summary>
    [Column("contact_id")]
    public int? ContactId { get; set; }
    /// <summary>
    /// Contact_id foreign key
    /// </summary>
    [ForeignKey("ContactId")]
    [InverseProperty("People")]
    public virtual PersonContact? Contact { get; set; }
    /// <summary>
    /// Person's customers
    /// </summary>
    [InverseProperty("Person")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
