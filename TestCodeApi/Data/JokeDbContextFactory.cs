using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestCodeApi.Data
{
    public class JokeDbContextFactory : IDesignTimeDbContextFactory<JokeDbContext>
    {
        public JokeDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("JakeDb");

            var optionsBuilder = new DbContextOptionsBuilder<JokeDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new JokeDbContext(optionsBuilder.Options);
        }
        
    }
}
