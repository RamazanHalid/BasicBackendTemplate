using ToDoList.Models.BusinessLogic.results;

namespace ToDoList.BusinessLogic.results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(T data ,bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
        
    }
}