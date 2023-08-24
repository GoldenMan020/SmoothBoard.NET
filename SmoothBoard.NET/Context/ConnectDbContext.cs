using Microsoft.EntityFrameworkCore;
using SmoothBoard.NET.Models;


namespace SmoothBoard.NET.Context
{
    public class ConnectDbContext : DbContext
    {
        // constractor aanmaken
        public ConnectDbContext(DbContextOptions<ConnectDbContext> contextOptions) : base(contextOptions)
        {

        }

        // klassen 

        public DbSet<Opdrachtgever> Opdrachtgevers { get; set; }



    }
}
