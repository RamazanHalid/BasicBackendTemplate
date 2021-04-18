namespace ToDoList.Models.BusinessLogic.results
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}