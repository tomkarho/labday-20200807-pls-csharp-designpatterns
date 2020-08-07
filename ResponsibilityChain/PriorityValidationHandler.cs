using System;
using Shared.Models;

namespace ResponsibilityChain {
    public class PriorityValidationHandler : Handler<Todo> {
        public override void Handle (Todo request) {
            if (request.Priority == Priority.Low) {
                throw new Exception ("No todo is that unimportant");
            }

            base.Handle (request);
        }
    }
}