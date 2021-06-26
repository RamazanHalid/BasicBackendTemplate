using ToDoList.Entities;

namespace ToDoList.DataAccess.EntityFramework
{
    public class UserDal: EfEntityRepositoryBase<User,MySQLContext>, IUserDal
    {
        
    }
}