## S - Single Responsibility Principle

> A class should have one and only one reason to change, meaning that a class should have only one job.
> 

**Key Idea:** A class should do only one thing, and it should do it well.

Before:

```csharp
public class UserService
{
    public async Task AddUser(User user)
    {
	    // Code to add a user to the Database
    }
    public async Task SendEmail(User user)
    {
	    // Code to send email to the user
	  }
}
```

After:

```csharp
public class UserService
{
    public async Task AddUser(User user)
    {
	    // Code to add a user to the Database
    }
}

public class EmailService
{
    public async Task SendEmail(User user)
    {
	    // Code to send email to the user
	  }
}
```

**Explanation:** According to SRP, *one class should take one responsibility hence to overcome this problem we should write another class to save the report functionality. If you make any changes to the `UserService` class will not affect the `EmailService` class.*