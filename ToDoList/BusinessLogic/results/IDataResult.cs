namespace ToDoList.Models.BusinessLogic.results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}