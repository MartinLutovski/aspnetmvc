using Avenga.TodoApp.Services.Dtos;
using Avenga.TodoApp.Services.Services.Interfaces;
using Avenga.TodoApp.ViewModels;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreateTodoVM model)
        {

            return View();
        }
        [HttpPost]

        public IActionResult MarkComplete(int todoId)
        {
            var response = _todoservice.MarkComplete(todoId);
            if (!response)
            {
                ViewBag["Error message"] = "Todo doesnt exist!";

            }
            return RedirectToAction("Index");
        }
    }
}