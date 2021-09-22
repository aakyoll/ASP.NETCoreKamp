using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("server=SOFTWAREENG\\SQLEXPRESS; database=CoreKamp; integrated security=true;");
    }

    public DbSet<About> About { get; set; }
    public DbSet<Blog> Blog { get; set; }

    internal void Delete(Blog blog)
    {
      throw new NotImplementedException();
    }

    public DbSet<Category> Category { get; set; }
    public DbSet<Comment>Comment { get; set; }
    public DbSet<Contact>Contact { get; set; }
    public DbSet<Writer>Writer { get; set; }
  }
}
