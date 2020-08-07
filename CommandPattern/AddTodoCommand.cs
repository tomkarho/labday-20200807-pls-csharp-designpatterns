using Shared;
using Shared.Models;
using Shared.Repositories;

namespace CommandPattern
{
    public class AddTodoCommand : ICommand
    {
        private readonly ITodoRepository _todoRepo;
        private readonly Todo _todo;

        public AddTodoCommand(ITodoRepository todoRepo, Todo todo)
        {
            _todoRepo = todoRepo;
            _todo = todo;
        }

        public bool CanExecute()
        {
            if(_todo == null) return false;

            return true;
        }

        public void Execute()
        {
            if(_todo == null) return;
            
            _todoRepo.AddTodo(_todo);
        }

        public void Undo()
        {
            _todoRepo.RemoveTodo(_todo);
        }
    }
}