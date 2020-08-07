using System;
using System.Collections.Generic;
using Shared.Models;

namespace Shared.Repositories
{
    public interface ITodoRepository
    {
         List<Todo> GetTodos();
         void AddTodo(Todo todo);
         void RemoveTodo(Todo todo);
         
    }
}