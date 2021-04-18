using ToDoList.BusinessLogic.results;

namespace ToDoList.BusinessLogic.Utilities.results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}