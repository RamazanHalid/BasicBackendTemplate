using ToDoList.DataAccess.EntityFramework;
using ToDoList.Entities;

namespace ToDoList.DataAccess
{
    public class ToDoDal:EfEntityRepositoryBase<ToDo, MySQLContext>,IToDoDal
    {
        
    }
}