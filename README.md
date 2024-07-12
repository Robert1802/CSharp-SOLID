# S.O.L.I.D. Principles

### What are the S.O.L.I.D Principles and why do we need them?
These are a set of software design principles that instruct us on how to structure our functions and classes to make them as reliable, maintainable, and adaptable as feasible.

If the code you've built in the past doesn't meet your current needs, changing it can be costly. We want to jot down any code that will be altered. Changing your code a second, third, and fourth time should not add defects or make it difficult to scale your previous code.

### SOLID stands for:
- <a href="https://github.com/Robert1802/CSharp-SOLID/tree/master/1_S_Single_Responsibility_Principle">S: Single Responsibility Principle
- <a href="https://github.com/Robert1802/CSharp-SOLID/tree/master/2_O_Open_Closed_Principle">O: Open-Closed Principle
- <a href="https://github.com/Robert1802/CSharp-SOLID/tree/master/3_L_Liskov_Substitution_Principle">L: Liskov-Substitution Principle
- <a href="https://github.com/Robert1802/CSharp-SOLID/tree/master/4_I_Interface_Segregation_Principle">I: Interface Segregation Principle
- <a href="https://github.com/Robert1802/CSharp-SOLID/tree/master/5_D_Dependency_Inversion_Principle">D: Dependency Inversion Principle

### What is Low Coupling and High Cohesion?
*  Coupling
The degree of direct knowledge that one element has of another is called coupling.
* Cohesion
Within a module, this measures how closely connected components are. It's a metric for how closely things resemble one another. Do you have a lot of stuff in here that's mainly about the topic at hand? Is there anything in here that belongs somewhere else?

Our software is composed of a bunch of unit classes or objects. An object encapsulates data and relevant methods related to data. Objects should be loosely coupled, i.e., they should be less dependent on each other. Each object should know less about another object. The same goes for different features or modules. S.O.L.I.D Principles help to achieve it.

Feature: a collection of objects to perform a specific task is called feature (package).