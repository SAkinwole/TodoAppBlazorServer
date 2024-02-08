namespace TodoAppBlazorServer.Service
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;
        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem ("Wash clothes"),
                new TodoItem ("Sweep"),
                new TodoItem ("Eat Fruits")
            };
        }
        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }
        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }
        public void UnCompleted(TodoItem item)
        {
            item.Completed = false;
        }
    }
}
