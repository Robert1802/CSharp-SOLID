## O - OCP - Open Closed Principle

> The Open/Closed Principle suggests that a class should be open for extension but closed for modification. This means you can add new features without altering existing code.
> 

**Key Idea:** Once a class is written, it should be closed for modifications but open for extensions.

**Real-Time Example:** Your smartphone — you don’t open it up to add features; you just download apps to extend its capabilities.

***Before:***

```csharp
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}
```

This design may become problematic when adding new shapes. Modifying the `AreaCalculator` for each new shape violates the OCP.

***After:***

```csharp
public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    // implementation
}

public class Circle : IShape
{
    // implementation
}
```

By introducing an interface (`IShape`), new shapes like `Circle` can be added without modifying existing code, adhering to the OCP.

**Explanation:** According to OCP, *the class should be open for extension but closed for modification. So, When you introduce a new shape, then just implement it from the interface `IShape`. So `IShape`is open for extension but closed for further modification.*