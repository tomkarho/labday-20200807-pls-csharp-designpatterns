Collection of C# Design patterns
================================

This repository is my notes and code for trying out different design patterns from Pluralsight courses tagged C# Design Patterns.

Courses from pluralsight
------------------------

- [C# Design Patterns: Template Method](https://app.pluralsight.com/library/courses/e675d814-f209-4616-b77c-a50b2679f6c1)
- [C# Design Patterns: Factory and Abstract Factory](https://app.pluralsight.com/library/courses/4ce11389-a9c8-4d0a-a945-2b30dfd7cd80)
- [C# Design Patterns: Singleton](https://app.pluralsight.com/library/courses/c836f216-5a35-486e-ab24-328749313fd2)
- [C# Design Patterns: Data Access Patterns](https://app.pluralsight.com/library/courses/cfb0434a-b851-417d-9f3a-8ecc2a194d02)
- [C# Design Patterns: Visitor](https://app.pluralsight.com/library/courses/0f174fae-edcd-43a4-a21f-f237d523c9bf)
- [C# Design Patterns: Flyweight](https://app.pluralsight.com/library/courses/fe53e75e-6e80-40be-878f-8afde9269faa)
- [C# Design Patterns: Proxy](https://app.pluralsight.com/library/courses/8e0d9197-37f4-4a7a-97c4-fd2e08a75d40)
- [C# Design Patterns: Builder](https://app.pluralsight.com/library/courses/fe2bae25-d9a5-471d-9c94-a03a6b8eb5ce)
- [C# Design Patterns: Prototype](https://app.pluralsight.com/library/courses/75a285b1-b232-4ccc-ad43-27f7d0b809a2)
- [C# Design Patterns: Decorator](https://app.pluralsight.com/library/courses/355db6dd-e80b-4b13-b352-b382965d6e09)
- [C# Design Patterns: Mediator](https://app.pluralsight.com/library/courses/6c6601a1-4114-4d59-9dc9-299042d94aec)
- [C# Design Patterns: Facade](https://app.pluralsight.com/library/courses/cf2a002d-6e5a-4e88-9df2-d2377ff04e9a)
- [C# Design Patterns: Strategy](https://app.pluralsight.com/library/courses/edd31b0e-9972-49e8-8ea2-ab949f1bff58)
- [C# Design Patterns: Null Object](https://app.pluralsight.com/library/courses/3587ad34-4f7a-441f-9b6c-a2e394ffb3d8)
- [C# Design Patterns: Composite](https://app.pluralsight.com/library/courses/137684a1-d22f-4dca-a87f-e6b44bc44d99)
- [C# Design Patterns: State](https://app.pluralsight.com/library/courses/92bfd9af-fdbf-4864-85e3-f3f497d17bb5)
- [C# Design Patterns: Chain of Responsibility](https://app.pluralsight.com/library/courses/0fec4dc4-5de6-4f41-b5ea-7c8350e5dce1)
- [C# Design Patterns: Command](https://app.pluralsight.com/library/courses/de1d1815-b7b3-45ab-a359-b3b6c793fbfb)

### Command Pattern
[Stack](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=netcore-3.1) allows to keep track of exact order and undo commands in the correct order

### Chain of Responsibility
Identified by three characteristics
* has a sender that invokes a handles
* handler that runs through a chain of receiverse
* receiver that handles the given command

Example: Loggers in .net core:
1. Any component can call Logger.LogInformation()
2. Handler passes that call to all that implement interface ILogger
3. Receivers log the same message to different places for example
    * Console
    * File
    * Database

- receiver contains the logic necessary to act
- handler only makes sure that all receivers are invoked
- sender only needs to know about the interface

Idea: Could this be implemented as a caching mechanism?
1. User requests a Todo
2. Handler invokes (first) the cache
3. If cache does not have up to date data
4. Handler invokes database operation

Example 2: asp.net core middleware.
Take a a look at asp.net core startup.cs configure method that uses this pattern to configure the application.