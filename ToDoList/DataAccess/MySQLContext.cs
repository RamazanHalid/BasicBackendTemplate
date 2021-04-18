using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class MySQLContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;user=root;password=;database=to_do_list;");
            
        }
            
    }
}