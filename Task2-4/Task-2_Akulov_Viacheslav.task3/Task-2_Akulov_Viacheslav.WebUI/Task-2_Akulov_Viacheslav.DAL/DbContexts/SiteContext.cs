using System.Data.Entity;
using Task_2_Akulov_Viacheslav.Model.Models;
using Task_2_Akulov_Viacheslav.Models;


namespace Task_2_Akulov_Viacheslav.DAL.DbContexts
{
    /// <summary>
    /// The database context containing all the database entities
    /// </summary>
    public class SiteContext : DbContext
    {
        /// <summary>
        /// Articles entity DbSet
        /// </summary>
        public DbSet<Article> Articles { get; set; }
        /// <summary>
        /// Comments entity DbSets
        /// </summary>
        public DbSet<Comment> Comments { get; set; }
        /// <summary>
        /// UserForms entity DbSet
        /// </summary>
        public DbSet<UserForm> UserForms { get; set; }

        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        ///  Сonnection to the database
        /// </summary>
        /// <param name="connectionString">Connection string name</param>
        public SiteContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasMany(c => c.Tags)
                .WithMany(s => s.Articles)
                .Map(t => t.MapLeftKey("ArticleId")
                .MapRightKey("TagId")
                .ToTable("ArticleTAg"));
        }
    }
}
