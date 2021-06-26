using System.Collections.Generic;
using ToDoList.BusinessLogic.Utilities.results;
using ToDoList.Entities;

namespace ToDoList.BusinessLogic
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}