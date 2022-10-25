using Microsoft.EntityFrameworkCore;
#nullable enable
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {

    }

    public DbSet<Profile>? Profiles { get; set; }
    
}