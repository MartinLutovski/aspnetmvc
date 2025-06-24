using Avenga.TodoApp.DataAccess.Repositories;
using Avenga.TodoApp.Domain;
using Avenga.TodoApp.Services.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenga.TodoApp.Services.Services.Interfaces
{
    public class TodoService :ITodoService
    {
        private readonly IRepository<Todo> _todoRepository;
        public TodoService(IRepository<Todo> todoRepository)
        {
            _todoRepository = todoRepository;
        }
        

       public IEnumerable<TodoDto> GetAllTodos()
        {   var todoDtos = new List<TodoDto>();
            var todos = _todoRepository.GetAll();
            if (todos != null && todos.ToList().Count > 0)
            {
                foreach (var todo in todos)
                {
                    //Todo : finish the mapping logic
                }
                return todosDto;
            }
        }

    }
}
