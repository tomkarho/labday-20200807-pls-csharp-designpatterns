using System;
using System.Collections.Generic;
using System.Linq;
using Shared.Models;

namespace Shared.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private List<Todo> _todos = new List<Todo>();

        public TodoRepository()
        {
            for (var i = 0 ; i < 10 ; i++) {
                _todos.Add(new Todo {
                    Id = Guid.NewGuid(),
                    Title = $"Testi todo {i+1}"
                });
            }
        }

        public void AddTodo(Todo todo)
        {
            _todos.Add(todo);
        }

        public List<Todo> GetTodos()
        {
            return _todos;
        }

        public void RemoveTodo(Todo todo)
        {
            _todos.Remove(todo);
        }
    }
}