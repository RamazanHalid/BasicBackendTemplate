using System.Collections.Generic;
using ToDoList.BusinessLogic.Utilities.results;
using ToDoList.Entities;

namespace ToDoList.BusinessLogic
{
    public interface IToDoService
    {
        IDataResult<List<ToDo>> GetAll();
        IDataResult<ToDo> GetById(int id);
        IResult Add(ToDo toDo);
        IResult Delete(ToDo toDo);
        IResult Update(ToDo toDo);
        

    }
}