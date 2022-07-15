using Microsoft.EntityFrameworkCore;
using TestCodeApi.Model;
using TestCodeApi.Data.Configurations;

namespace TestCodeApi.Data
{
    public class JokeDbContext : DbContext
    {
        public JokeDbContext(DbContextOptions<JokeDbContext>  options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration using fluent API
            modelBuilder.ApplyConfiguration(new MJokeConfiguration());
        }

        public DbSet<MJoke> MJoke { get; set; }
    }
}
