> The Interface Segregation Principle states that a class should not be forced to implement interfaces it does not use. This principle encourages the creation of small, client-specific interfaces.
> 

**Key Idea:** A class should not be forced to implement interfaces it doesn’t use.

**Real-Time Example:** You sign up for a music streaming service and only choose the genres you like, not all available genres.

***Before:***

```csharp
public interface IWorker
{
    void Work();
    void Eat();
}

public class Manager : IWorker
{
    // implementation
}

public class Robot : IWorker
{
    // implementation
}
```

The `Robot` class is forced to implement the `Eat` method, violating ISP.

***After:***

```csharp
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Manager : IWorkable, IEatable
{
    // implementation
}

public class Robot : IWorkable
{
    // implementation
}
```

By splitting the `IWorker` interface into smaller interfaces (`IWorkable` and `IEatable`), classes can implement only what they need, adhering to ISP.

**Explanation:** According to LSP, *any client should not be forced to use an interface that is irrelevant to it. In other words, clients should not be forced to depend on methods that they do not use.*