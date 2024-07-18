## D - Dependency Inversion Principle

> The Dependency Inversion Principle suggests that high-level modules should not depend on low-level modules, but both should depend on abstractions. Additionally, abstractions should not depend on details; details should depend on abstractions.
> 

**Key Idea:** High-level modules should not depend on low-level modules; both should depend on abstractions.

**Real-Time Example:** Building a LEGO tower — the bricks (high and low-level modules) connect through smaller bricks (abstractions).

***Before:***

```csharp
public class LightBulb
{
    public void TurnOn() { /* implementation */ }
    public void TurnOff() { /* implementation */ }
}

public class Switch
{
    private LightBulb bulb;

    public Switch(LightBulb bulb)
    {
        this.bulb = bulb;
    }

    public void Toggle()
    {
        if (bulb.IsOn)
            bulb.TurnOff();
        else
            bulb.TurnOn();
    }
}
```

The `Switch` class directly depends on the concrete `LightBulb` class, violating DIP.

***After:***

```csharp
public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public class LightBulb : ISwitchable
{
    // implementation
}

public class Switch
{
    private ISwitchable device;

    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Toggle()
    {
        if (device.IsOn)
            device.TurnOff();
        else
            device.TurnOn();
    }
}
```

By introducing an interface (`ISwitchable`), the `Switch` class now depends on an abstraction, adhering to the Dependency Inversion Principle.

**Explanation:** According to DIP, *do not write any tightly coupled code because that is a nightmare to maintain when the application is growing bigger and bigger. If a class depends on another class, then we need to change one class if something changes in that dependent class. We should always try to write loosely coupled classes.*