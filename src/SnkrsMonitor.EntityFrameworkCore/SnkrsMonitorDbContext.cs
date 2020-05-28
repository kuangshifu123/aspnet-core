using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SnkrsMonitor
{
    [ConnectionStringName("SqlServer")]
    public class SnkrsMonitorDbContext : AbpDbContext<SnkrsMonitorDbContext>
    {
        public DbSet<SnkrsMonitor.Product.Product> Products { get; set; }

        //public DbSet<Category> Categories { get; set; }

        //public DbSet<Tag> Tags { get; set; }

        //public DbSet<PostTag> PostTags { get; set; }

        //public DbSet<FriendLink> FriendLinks { get; set; }

        //public DbSet<Signature> Signatures { get; set; }

        //public DbSet<Wallpaper> Wallpapers { get; set; }

        //public DbSet<HotNews> HotNews { get; set; }

        //public DbSet<ChickenSoup> ChickenSoups { get; set; }

        //public DbSet<Album> Albums { get; set; }

        //public DbSet<Image> Images { get; set; }

        public SnkrsMonitorDbContext(DbContextOptions<SnkrsMonitorDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
