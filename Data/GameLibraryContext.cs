using Microsoft.EntityFrameworkCore;
using DevOpsSummer2026.Models;
namespace DevOpsSummer2026.Data
{
    public class GameLibraryContext : DbContext
    {
        public GameLibraryContext(DbContextOptions<GameLibraryContext>options):base(options)
        {
        }
        public DbSet<Game>Games { get; set; }
    }
}