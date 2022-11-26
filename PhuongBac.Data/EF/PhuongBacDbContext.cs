using Microsoft.EntityFrameworkCore;
using PhuongBac.Data.Configurations;
using PhuongBac.Data.Entities;

namespace PhuongBac.Data.EF
{
    public class PhuongBacDbContext : DbContext
    {
        public PhuongBacDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new InsurancePartnerConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new PostInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new TagInPostConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
            modelBuilder.ApplyConfiguration(new VideoConfiguration());
            modelBuilder.ApplyConfiguration(new VideoInCategoryConfiguration());
        }

        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<InsurancePartner> InsurancePartners { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostInCategory> PostInCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagInPost> TagInPosts { get; set; }
        public DbSet<Entities.Type> Types { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
