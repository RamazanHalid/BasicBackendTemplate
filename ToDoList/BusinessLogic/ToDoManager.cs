using System.Collections.Generic;
using ToDoList.BusinessLogic.results;
using ToDoList.BusinessLogic.Utilities.results;
using ToDoList.DataAccess;
using ToDoList.Entities;


namespace ToDoList.BusinessLogic
{
    public class ToDoManager:IToDoService
    {
        private IToDoDal _toDoDal;

        public ToDoManager(IToDoDal toDoDal)
        {
            _toDoDal = toDoDal;
        }

        public IDataResult<List<ToDo>> GetAll()
        {
            return new SuccessDataResult< List<ToDo> >(_toDoDal.GetAll(), Messages.ToDoList);
        }

        public IDataResult<ToDo> GetById(int id)
        {
            return new SuccessDataResult<ToDo>(_toDoDal.Get(t => t.ToDoId == id));
        }

        public IResult Add(ToDo toDo)
        {
            _toDoDal.Add(toDo);
            return new SuccessResult(Messages.ToDoAdded);
        }

        public IResult Delete(ToDo toDo)
        {
            _toDoDal.Delete(toDo);
            return new SuccessResult(Messages.ToDoDeleted);
        }

        public IResult Update(ToDo toDo)
        {
            _toDoDal.Update(toDo);
            return new SuccessResult(Messages.ToDoUpdated);
        }
    }
}