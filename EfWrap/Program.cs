using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

context.Users.Add(new User("",1));
context.SaveChanges();



public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public AppDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlite("Data Source = test.db");
    }


}



public class User
{
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

