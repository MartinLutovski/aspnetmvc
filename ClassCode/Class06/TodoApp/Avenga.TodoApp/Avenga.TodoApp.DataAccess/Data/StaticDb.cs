using Avenga.TodoApp.Domain;

namespace Avenga.TodoApp.DataAccess.Data
{
    public static class StaticDb
    {
        public static List<Todo> Todos { get; private set; }
        public static List<Category> Categories { get; private set; }
        public static List<Status> Statuses { get; private set; }

        // Static constructor initializes mock data
        static Db()
        {
            Categories = LoadCategories();
            Statuses = LoadStatuses();
            Todos = LoadTodos();
        }

        private static List<Category> LoadCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Work" },
                new Category { Id = 2, Name = "Home" },
                new Category { Id = 3, Name = "Exercise" },
                new Category { Id = 4, Name = "Shopping" },
                new Category { Id = 5, Name = "Hobbies" },
                new Category { Id = 6, Name = "FreeTime" }
            };
        }

        private static List<Status> LoadStatuses()
        {
            return new List<Status>
            {
                new Status { Id = 1, Name = "Open" },
                new Status { Id = 2, Name = "Closed" }
            };
        }

        private static List<Todo> LoadTodos()
        {
            return new List<Todo>
            {
                new Todo
                {
                    Id = 1,
                    Description = "Finish project report",
                    DueDate = DateTime.Today.AddDays(1),
                    CategoryId = 1, // Work
                    StatusId = 1    // Open
                },
                new Todo
                {
                    Id = 2,
                    Description = "Buy groceries",
                    DueDate = DateTime.Today.AddDays(2),
                    CategoryId = 4, // Shopping
                    StatusId = 1    // Open
                },
                new Todo
                {
                    Id = 3,
                    Description = "Clean the garage",
                    DueDate = DateTime.Today.AddDays(3),
                    CategoryId = 2, // Home
                    StatusId = 2    // Closed
                },
                new Todo
                {
                    Id = 4,
                    Description = "Go for a 5km run",
                    DueDate = DateTime.Today.AddDays(1),
                    CategoryId = 3, // Exercise
                    StatusId = 1    // Open
                },
                new Todo
                {
                    Id = 5,
                    Description = "Paint a landscape",
                    DueDate = DateTime.Today.AddDays(4),
                    CategoryId = 5, // Hobbies
                    StatusId = 2    // Closed
                }
            };
        }
    }
}
