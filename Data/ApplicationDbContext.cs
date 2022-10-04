using Falz_Yummy_Pizza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Falz_Yummy_Pizza.Data
{ }
public class ApplicationDbContext : DbContext
{ 
      public DbSet<PizzaOrder> PizzaOrders { get; set; }
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
   
    }
      
}
