# Design Patterns in .NET Console Application

This project is a .NET console application that demonstrates the implementation of various design patterns in programming. The purpose of this project is to showcase the practical use of design patterns, helping developers understand how to implement them effectively in real-world applications.

## Table of Contents
- [Overview](#overview)
- [Design Patterns Implemented](#design-patterns-implemented)
  - [Builder Pattern](#builder-pattern)
  - [Factory Pattern](#factory-pattern)
  - [Singleton Pattern](#singleton-pattern)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)

## Overview
Design patterns are proven solutions to common software design problems. They provide a template for writing software that is easy to understand, modify, and maintain. This project currently includes examples of three design patterns: Builder, Factory, and Singleton. Each pattern is implemented in a way that is easy to follow and understand.

## Design Patterns Implemented

### Builder Pattern
The Builder Pattern is used to construct a complex object step by step. Unlike other creational patterns, which focus on the instantiation process, the Builder Pattern involves a more detailed construction process. This pattern is particularly useful when the object creation process involves many steps or parameters.

**Example Use Case:**
- Constructing a `House` object with various attributes like door, roof and number of stories.

### Factory Pattern
The Factory Pattern provides a way to create objects without specifying the exact class of the object that will be created. It is used when the exact type of the object is not known until runtime. This pattern promotes loose coupling by delegating the responsibility of object instantiation to factory classes.

**Example Use Case:**
- Implementing various types of `Payment` like `CreditCardPayment`, `PayPalPayment`, and `GooglePayPayment`.

### Singleton Pattern
The Singleton Pattern ensures that a class has only one instance and provides a global point of access to it. This pattern is commonly used for resources that are expensive to create or need to be shared across the application, such as database connections or configuration settings.

**Example Use Case:**
- Managing a single instance of a UploadService.

## Getting Started

To get started with this project, clone the repository and build the solution using Visual Studio or the .NET CLI.

```bash
git clone https://github.com/AmirHosein-Ashkbar/DesignPatterns.git
cd the desired design pattern folder
dotnet build
```

Ensure you have the .NET SDK installed on your machine. You can download it from the [.NET website](https://dotnet.microsoft.com/download).

## Usage

Run the console application using the .NET CLI or from Visual Studio. The application will demonstrate the use of each design pattern with examples.

```bash
dotnet run
```

You can also explore the code to see how each design pattern is implemented. Each pattern is located in its respective folder under the `DesignPatterns` directory.

## Contributing

Contributions are welcome! If you would like to contribute to this project, please fork the repository and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.


---

Feel free to modify this `README.md` file to better suit your project's specific details or structure. Good luck with your project!
