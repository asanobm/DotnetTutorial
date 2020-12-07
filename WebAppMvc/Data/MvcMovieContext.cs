using Microsoft.EntityFrameworkCore;
using WebAppMvc.Models;

namespace WebAppMvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(
            DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}