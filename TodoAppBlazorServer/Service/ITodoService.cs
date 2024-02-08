namespace TodoAppBlazorServer.Service
{
    public interface ITodoService
    {
        void Add(TodoItem item);
        IEnumerable<TodoItem> GetAll();
        void Delete(TodoItem item);
        void Complete(TodoItem item);
        void UnCompleted(TodoItem item);
    }
}
