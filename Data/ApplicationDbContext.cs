using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;

namespace PersonalWebsite.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Comment> Comments { get; set; }
}



