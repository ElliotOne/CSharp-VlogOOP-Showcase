# CSharp-VlogOOP-Showcase

## Overview

Welcome to the **CSharp Vlog OOP Showcase** project! This is a **C# console application** designed to demonstrate core Object-Oriented Programming (OOP) principles through a fun, practical example involving writers, vloggers, promoters, and bodybuilders.

The goal of this project is to clearly illustrate how inheritance, abstraction, interfaces, and polymorphism work in C#, ideal for learners looking to understand real-world applications of OOP.

---

## Project Structure

- **CSharp-VlogOOPShowcase**: A console app that:
  - Defines a class hierarchy for writers and promoters.
  - Demonstrates interface implementation for vloggers and bodybuilders.
  - Uses method overriding and abstract classes to highlight polymorphism and abstraction.
  - Outputs behaviors based on class types and interface implementations.

---

## Features

- Demonstrates **inheritance** through shared base classes (`Writer`, `Promoter`).
- Applies **abstraction** using abstract methods for reusable behavior.
- Implements **interfaces** (`IVlogger`, `IBodyBuilder`) for behavior contracts.
- Showcases **polymorphism** by interacting with objects via base types/interfaces.
- Clean separation of concerns using individual classes per role.
- Clear console output to illustrate which classes are performing which actions.
- Encourages good design principles in a playful, creative scenario.

---

## How It Works

- Writers and promoters inherit from abstract base classes and override methods for their specific behavior.
- Some classes implement multiple interfaces to represent diverse roles (e.g., `XSClubPromoter` is a promoter, bodybuilder, and vlogger).
- Lists of different base types (`Writer`, `Promoter`, `IVlogger`, `IBodyBuilder`) are used to demonstrate polymorphic behavior via `foreach` loops.
- Console output provides a trace of method calls based on the object's actual type.

---

## Output Example

I share with my Instagram followers.<br>
I use Facebook ads.<br>
I share with my Instagram followers.<br>
I use Facebook ads.<br>
I share with my friends.<br>
I use Google AdWords.<br>
I write books.<br>
I write books.<br>
I write for my own blog.<br>
I work out at my house.<br>
I work out at my house.<br>
I vlog using my iPhone.<br>
I vlog using my GoPro.<br>

---

## How to Run

1. Open the solution in **Visual Studio** or your preferred C# IDE.
2. Set the project as the startup project.
3. Press `F5` or run the project.
4. Observe the console output as the program executes behaviors via OOP constructs.

---

## Screenshots

### Console Output

![Console Output](https://github.com/ElliotOne/CSharp-VlogOOP-Showcase/blob/master/screenshots/first.png)

---

## Technologies Used

- [.NET 6](https://dotnet.microsoft.com/)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio](https://visualstudio.microsoft.com/)

---

## License

This project is licensed under the MIT License. Feel free to use, modify, and distribute it.

---

## Contributions

Contributions are welcome! You can fork the repo, submit issues, or open pull requests to improve the educational value of the project by:

- Adding new roles (e.g., Podcaster, Influencer) to extend the OOP demonstration.
- Enhancing the UI or making it interactive.
- Including logging or reporting tools.
