using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace WolvenKit.Common.Model.Database;

public class RedDBContext : DbContext
{
    public RedDBContext()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        DbPath = Path.Combine(dir, Constants.RedDb);
    }

    public DbSet<RedArchive>? Archives { get; set; }
    public DbSet<RedFile>? Files { get; set; }

    public string DbPath { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RedArchive>(entity =>
        {
            entity
                .HasKey(nameof(RedArchive.Id));

            entity
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            entity
                .Property(a => a.Name)
                .HasMaxLength(255)
                .IsRequired();

            entity
                .HasIndex(nameof(RedArchive.Name), nameof(RedArchive.Source))
                .IsUnique();
        });

        modelBuilder.Entity<RedFile>(entity =>
        {
            entity
                .HasKey(nameof(RedFile.Id));

            entity
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            entity
                .HasOne(f => f.Archive)
                .WithMany(a => a.Files)
                .IsRequired();

            entity
                .HasIndex(nameof(RedFile.ArchiveId), nameof(RedFile.Hash))
                .IsUnique();

            entity
                .HasMany(x => x.Uses);
        });

        modelBuilder.Entity<RedFileUse>(entity => entity
                .HasKey(nameof(RedFileUse.RedFileId), nameof(RedFileUse.Hash)));
    }

    public static void ClearDatabase()
    {
        using var client = new RedDBContext();
        client.Database.EnsureDeleted();
        client.Database.EnsureCreated();
    }
}
