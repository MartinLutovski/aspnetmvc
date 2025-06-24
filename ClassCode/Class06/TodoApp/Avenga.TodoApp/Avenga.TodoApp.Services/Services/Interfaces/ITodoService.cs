using Avenga.TodoApp.Services.Services.Dtos;

namespace Avenga.TodoApp.Services.Services.Interfaces
{
    public interface ITodoService
    {
        IEnumerable<TodoDto> GetAllTodos();

    }
}
