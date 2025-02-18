# ASP.NET Core MVC Example

This project demonstrates a basic ASP.NET Core MVC setup with the use of **Extension Methods**, **LINQ**, **Delegates**, and **Lambda Expressions** for filtering and processing data.

## Features

- **Extension Methods**: Adds new functionality to existing types (like `IEnumerable<Product?>`) without modifying them.
- **LINQ**: Provides a concise, readable way to query and manipulate collections.
- **Delegates**: Passes methods as parameters to allow flexible, reusable filtering logic.
- **Lambda Expressions**: Offers a shorthand syntax for defining anonymous methods, making code more concise and readable.

## Key Concepts Demonstrated

### 1. **Extension Methods**

- **TotalPrices**: Calculates the total price of a collection of products. This extension method is defined on `IEnumerable<Product?>` and can be applied to any collection of products.
- **FilterByPrice**: Filters a collection of products based on a minimum price. This extension method provides an easy way to filter products in any collection.
- **Filter**: A flexible extension method that allows filtering a collection of products using a delegate (`Func<Product?, bool>`) passed as an argument.

### 2. **LINQ (Language Integrated Query)**

LINQ is used throughout the project to filter and aggregate data. In this project, it is demonstrated through methods like `Filter` and `TotalPrices` that work with collections of products. These methods provide a clean, declarative way to work with collections.

### 3. **Delegates**

Delegates are used to pass custom filtering logic. The `Filter` method uses the `Func<Product?, bool>` delegate, allowing different filtering conditions to be passed dynamically.

### 4. **Lambda Expressions**

Lambda expressions are used to create concise inline functions. In this project, they are used to define custom filtering conditions, making the code more readable and concise.

## Project Structure

- **Models**: Contains the `Product` and `ShoppingCart` classes, which represent the data and the logic for handling it.
- **Controllers**: Contains the `HomeController`, where the data filtering logic is executed and results are passed to the view.
- **Program.cs**: Configures and runs the web application with MVC support and default routing.

## Installation

1. Clone this repository to your local machine.
2. Make sure you have [.NET 8](https://dotnet.microsoft.com/download) installed.
3. Navigate to the project folder and run:

   ```bash
   dotnet run
