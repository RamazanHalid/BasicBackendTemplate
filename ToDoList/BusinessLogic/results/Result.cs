using ToDoList.Models.BusinessLogic.results;

namespace ToDoList.BusinessLogic.results
{
    public class Result:IResult
    {
        
        
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

      

        public bool Success { get; }
        public string Message { get; }
        
    }
}