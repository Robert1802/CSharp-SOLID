## L - LSP - Liskov Substitution Principle

> The Liskov Substitution Principle states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
> 

**Key Idea:** You should be able to use any subclass where you use its parent class.

**Real-Time Example:** You have a remote control that works for all types of TVs, regardless of the brand.

***Before:***

```csharp
public class Bird
{
    public virtual void Fly() { /* implementation */ }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins can't fly!");
    }
}
```

Here, the `Penguin` class violates the LSP by throwing an exception for the `Fly` method.

***After:***

```csharp
public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Fly()
    {
        // implementation specific to Bird
    }
}

public class Penguin : IFlyable
{
    public void Fly()
    {
        // implementation specific to Penguins
        throw new NotImplementedException("Penguins can't fly!");
    }
}
```

By introducing the `IFlyable` interface, both `Bird` and `Penguin` adhere to the Liskov Substitution Principle.

**Explanation:** According to LSP, *a derived class should not break the base class’s type definition and behavior which means objects of a base class shall be replaceable with objects of its derived classes without breaking the application.* This needs the objects of derived classes to behave in the same way as the objects of your base class.