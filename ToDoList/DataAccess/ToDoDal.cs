using ToDoList.Models.Entities;
using ToDoList.Models.EntityFramework;

namespace ToDoList.Models
{
    public class ToDoDal:EfEntityRepositoryBase<ToDo, MySQLContext>
    {
        
    }
}