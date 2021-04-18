namespace ToDoList.BusinessLogic.Utilities.results
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}