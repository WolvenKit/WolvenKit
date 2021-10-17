using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WolvenKit.MSTests.Model
{
    public class RedDBContext : DbContext
    {
        public RedDBContext()
        {
            const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}red.db";
        }

        public DbSet<RedFile> Files { get; set; }

        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RedFile>()
            .Property(e => e.Uses)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => ulong.Parse(x))
                    .ToArray()
            );

            modelBuilder.Entity<RedFile>()
           .Property(e => e.UsedBy)
           .HasConversion(
               v => string.Join(',', v),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => ulong.Parse(x))
                   .ToArray()
           );
        }

    }
}
