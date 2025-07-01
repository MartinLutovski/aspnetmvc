using Avenga.TodoApp.Services.Dtos;
using Avenga.TodoApp.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Avenga.TodoApp.Web.Controllers
{

    public class TodoController : Controller
    {
        private readonly ITodoService _todoservice;

        public TodoController(ITodoService todoService)
        {
            _todoservice = todoService;
        }
        public IActionResult Index()
        {
            List<TodoDto> todos = _todoservice.GetAllTodos().ToList();
            return View(todos);
        }
    }
}
