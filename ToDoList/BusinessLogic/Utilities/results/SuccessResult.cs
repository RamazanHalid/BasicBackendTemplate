using ToDoList.BusinessLogic.results;

namespace ToDoList.BusinessLogic.Utilities.results
{
    public class SuccessResult:Result
    {
        public SuccessResult( string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}