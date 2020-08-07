using System;
using Shared.Models;

namespace ResponsibilityChain {
    public class TitleValidationHandler : Handler<Todo> {
        public override void Handle (Todo request) {
            if (string.IsNullOrWhiteSpace (request.Title)) {
                throw new Exception ("Title cannot be empty");
            }

            base.Handle (request);
        }
    }
}