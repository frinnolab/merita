using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptionsBuilder<DataContext> options)
    {
        options.UseInMemoryDatabase(databaseName:"meritaDB");
    }

    public DbSet<Profile> Profiles { get; set; }
    
}