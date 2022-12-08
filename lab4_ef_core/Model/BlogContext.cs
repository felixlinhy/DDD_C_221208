using Microsoft.EntityFrameworkCore;
namespace Model;
public class BlogContext : DbContext
{
    public DbSet<Blog>? Blogs {get; set;}
    public DbSet<Post>? Posts{get; set;}
    public string DbPath {get;}
    public BlogContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var Path= Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(Path, "lab4.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
}