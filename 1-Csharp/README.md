# C# Review

This document covers the fundamental concepts of C# for beginner programmers, with clear explanations, code examples, and best practices.

## 1. Object-Oriented Programming (OOP) Principles

### 1.1 Abstraction

Abstraction helps simplify reality by focusing only on essential details of an object. For example, a `Person` class might include only relevant properties:

```csharp
class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}
```

### 1.2 Encapsulation

Encapsulation hides the internal implementation of a class, allowing access only to what is necessary.

```csharp
class BankAccount {
    private double balance;
    
    public void Deposit(double amount) {
        balance += amount;
    }
    
    public double GetBalance() {
        return balance;
    }
}
```

### 1.3 Inheritance

Allows one class to derive from another, inheriting its properties and methods.

```csharp
class Animal {
    public void MakeSound() {
        Console.WriteLine("Making sound...");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Woof woof!");
    }
}
```

### 1.4 Polymorphism

Allows a method to have different implementations.

```csharp
class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("Generic sound");
    }
}

class Dog : Animal {
    public override void MakeSound() {
        Console.WriteLine("Woof!");
    }
}
```

## 2. Data Types in C#

### 2.1 Value Types vs Reference Types

- **Value Types**: Stored in the stack and directly contain data. Example: `int`, `double`, `struct`.
- **Reference Types**: Stored in the heap, and the variable holds a reference to the memory location. Example: `class`, `string`, `array`.

```csharp
int valueA = 5;
int valueB = valueA; // Copies the value

string textA = "Hello";
string textB = textA; // Copies the reference
```

## 3. Collections in C#

### 3.1 Generic Collections

```csharp
List<int> numbers = new List<int>() { 1, 2, 3 };
Dictionary<string, int> ages = new Dictionary<string, int> { {"John", 30}, {"Anna", 25} };
```

### 3.2 Non-Generic Collections (Obsolete)

It is recommended to use generic collections instead of `ArrayList` and `Hashtable` for security and performance reasons.

## 4. Access Modifiers

- `public`: Accessible from anywhere.
- `private`: Accessible only within the class.
- `protected`: Accessible within the class and derived classes.
- `internal`: Accessible within the same assembly.

## 5. Abstract Classes vs Interfaces

### 5.1 Abstract Class

```csharp
abstract class Shape {
    public abstract double CalculateArea();
}
```

### 5.2 Interface

```csharp
interface IAnimal {
    void MakeSound();
}
```

**When to use what?**

- Use an **interface** when unrelated classes share a behavior.
- Use an **abstract class** when there is a clear hierarchical relationship.

## 6. Extension Methods

Allow adding functionality to existing classes without modifying them.

```csharp
public static class StringExtensions {
    public static string CapitalizeFirstLetter(this string text) {
        return char.ToUpper(text[0]) + text.Substring(1);
    }
}
```

## 7. LINQ

LINQ (Language Integrated Query) enables fluent queries on collections.

```csharp
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
```

## 8. Exception Handling

```csharp
try {
    int result = 10 / 0;
} catch (DivideByZeroException ex) {
    Console.WriteLine("Cannot divide by zero.");
} finally {
    Console.WriteLine("Execution completed.");
}
```

## 9. HTTP Client (APIs)

```csharp
using (HttpClient client = new HttpClient()) {
    HttpResponseMessage response = await client.GetAsync("https://api.example.com/data");
    string content = await response.Content.ReadAsStringAsync();
    Console.WriteLine(content);
}
```

## Conclusion

This review covers the essential concepts of C#. It is recommended to continue practicing and exploring official documentation for deeper understanding.
