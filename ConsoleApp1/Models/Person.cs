using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("person")]
public partial class Person
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("surname")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Surname { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("contact_id")]
    public int? ContactId { get; set; }

    [ForeignKey("ContactId")]
    [InverseProperty("People")]
    public virtual PersonContact? Contact { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
