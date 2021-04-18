using ToDoList.DataAccess;
using ToDoList.Models.Entities;

namespace ToDoList.Models
{
    public interface IToDoDal:IEntityRepository<ToDo>
    {
        
    }
}