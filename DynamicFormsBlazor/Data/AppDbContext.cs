using DynamicFormsBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicFormsBlazor.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<FormDefinition> FormDefinitions => Set<FormDefinition>();
    public DbSet<FormFieldDefinition> FormFieldDefinitions => Set<FormFieldDefinition>();
    public DbSet<FormFieldOptionDefinition> FormFieldOptionDefinitions => Set<FormFieldOptionDefinition>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FormFieldDefinition>()
            .HasOne(f => f.FormDefinition)
            .WithMany(d => d.Fields)
            .HasForeignKey(f => f.FormDefinitionId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<FormFieldOptionDefinition>()
            .HasOne(o => o.FormField)
            .WithMany(f => f.Options)
            .HasForeignKey(o => o.FormFieldDefinitionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}


