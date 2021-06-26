using ToDoList.BusinessLogic.Utilities.results;
using ToDoList.Entities;

namespace ToDoList.BusinessLogic.Abstract
{
    public interface IAuthService
    {
      IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
      IDataResult<User> Login(UserForLoginDto userForLoginDto);
      IResult UserExists(string email);
    }
}