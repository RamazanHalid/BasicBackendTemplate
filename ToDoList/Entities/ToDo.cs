namespace ToDoList.Entities
{
    public class ToDo:IEntity
    {
        public int ToDoId { get; set; }
        public string ToDoName { get; set; }
        public string ToDoDescription { get; set; }
    }
}