using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.Movie> Movie { get; set; }
    }
}