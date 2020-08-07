using System;
using Shared;
using Shared.Models;
using Shared.Repositories;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandRepo = new CommandManager();
            TodoRepository todoRepo = new TodoRepository();
            Console.WriteLine("Hello World!");

            Console.WriteLine($"There are {todoRepo.GetTodos().Count} Todos!");

            Console.WriteLine("Give me something todo");
            Console.Write(":");

            var todo = new Todo {
                Id = Guid.NewGuid(),
                Title = Console.ReadLine()
            };

            commandRepo.Invoke(new AddTodoCommand(todoRepo, todo));

            Console.WriteLine($"There are {todoRepo.GetTodos().Count} Todos now!");
        }
    }
}
