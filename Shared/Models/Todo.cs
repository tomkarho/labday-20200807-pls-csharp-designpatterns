using System;

namespace Shared.Models
{
    public class Todo
    {
        public Guid Id {get;set;}
        public string Title {get;set;}
        public Priority Priority {get;set;}
    }
}