using Microsoft.EntityFrameworkCore;
using ToDoList.Entities;

namespace ToDoList.DataAccess.EntityFramework
{
    public class MySQLContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;user=root;password=;database=to_do_list;");
            
        }
            public DbSet<ToDo> ToDos { get; set; }
            public DbSet<User> Users { get; set; }
    }
}