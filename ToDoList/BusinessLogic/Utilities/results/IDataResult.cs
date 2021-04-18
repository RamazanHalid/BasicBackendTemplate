namespace ToDoList.BusinessLogic.Utilities.results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}