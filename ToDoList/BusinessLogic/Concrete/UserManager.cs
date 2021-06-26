using System.Collections.Generic;
using ToDoList.BusinessLogic.Utilities.results;
using ToDoList.DataAccess;
using ToDoList.Entities;

namespace ToDoList.BusinessLogic
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"User list");
        }

        public IDataResult<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("User Added!");
        }

        public IResult Delete(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}