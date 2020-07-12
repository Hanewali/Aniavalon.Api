using Aniavalon.Api.Models;
using Aniavalon.Api.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Aniavalon.Api.DAL
{
    public class StatisticsContext : DbContext
    {
        public StatisticsContext(DbContextOptions<StatisticsContext> options) : base(options){}

        public DbSet<PersonXSide> PersonXSides { get; set; }

    }
}