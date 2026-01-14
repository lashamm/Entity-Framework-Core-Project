using System;
using System.Collections.Generic;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Data;

public partial class ItStepProjectContext : DbContext
{
    public ItStepProjectContext()
    {
    }

    public ItStepProjectContext(DbContextOptions<ItStepProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PersonContact> PersonContacts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductTitle> ProductTitles { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-UB75BK9;Database=ItStepProject;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__branch__3213E83F6F10327B");

            entity.HasOne(d => d.City).WithMany(p => p.Branches).HasConstraintName("FK__branch__city_id__5FB337D6");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__brand__3213E83FEA0AAB7D");

            entity.HasOne(d => d.BrandModel).WithMany(p => p.Brands).HasConstraintName("FK__brand__brand_mod__5535A963");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__city__3213E83FFE8E5194");

            entity.HasOne(d => d.Street).WithMany(p => p.Cities).HasConstraintName("FK__city__street_id__5CD6CB2B");
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__contact___3213E83F7AFE83BD");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83FE434A87F");

            entity.HasOne(d => d.Person).WithMany(p => p.Customers).HasConstraintName("FK__customer__person__6A30C649");
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F1B7ABC56");

            entity.HasOne(d => d.Branch).WithMany(p => p.CustomerOrders).HasConstraintName("FK__customer___branc__6E01572D");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerOrders).HasConstraintName("FK__customer___custo__6D0D32F4");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__model__3213E83F3A353B56");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__order_de__3213E83F29833917");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__person__3213E83F0A751A9F");

            entity.HasOne(d => d.Contact).WithMany(p => p.People).HasConstraintName("FK__person__contact___6754599E");
        });

        modelBuilder.Entity<PersonContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__person_c__3213E83F83324E7F");

            entity.HasOne(d => d.ContactType).WithMany(p => p.PersonContacts).HasConstraintName("FK__person_co__conta__6477ECF3");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__product__3213E83F00BF4D38");

            entity.HasOne(d => d.ProductTitle).WithMany(p => p.Products).HasConstraintName("FK__product__brand_i__4CA06362");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__product___3213E83F0F298959");
        });

        modelBuilder.Entity<ProductTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__product___3213E83F7758ADD4");
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__street__3213E83FDA227612");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
