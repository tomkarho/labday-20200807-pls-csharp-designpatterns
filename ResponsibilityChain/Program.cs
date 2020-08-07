using System;
using Shared.Models;
using Shared.Repositories;

namespace ResponsibilityChain {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            var todos = new TodoRepository();

            try
            {
                var handler = new TitleValidationHandler();

                handler.SetNext(new PriorityValidationHandler());

                var task = new Todo {
                    Title = "test",
                    Priority = Priority.High
                };

                handler.Handle(task);

                Console.WriteLine($"{task.Title} - {task.Priority}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}{Environment.NewLine}{e.StackTrace}");
            }
        }
    }
}