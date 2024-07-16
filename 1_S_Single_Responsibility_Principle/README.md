## S - Single Responsibility Principle

> A class should have one and only one reason to change, meaning that a class should have only one job.
> 

**Key Idea**: A class should do only one thing, and it should do it well.

**Real-Time Example**: Think of a chef who only focuses on cooking, not managing the restaurant or delivering food.

**Key Idea:** A class should do only one thing, and it should do it well.

Before:

```csharp
class ReportGenerator {
    public void generatePDFReport() {
        // logic to generate a PDF report
    }

    public void generateCSVReport() {
        // logic to generate a CSV report
    }

    public void sendEmail() {
        // logic to send an email
    }
}
```

After:

```csharp
class PDFReportGenerator {
    public void generatePDFReport() {
        // logic to generate a PDF report
    }
}

class CSVReportGenerator {
    public void generateCSVReport() {
        // logic to generate a CSV report
    }
}

class EmailSender {
    public void sendEmail() {
        // logic to send an email
    }
}
```

**Explanation:** By adhering to SRP, each class now has a single responsibility, making the code more maintainable and easier to extend.