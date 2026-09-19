# CustomMath

A simple C# mathematics library created for learning purposes.

This project is a personal learning project where I practice C# fundamentals by implementing mathematical operations and utility functions from scratch.

## Features

| Function     | Type    | Description                                           |
| ------------ | ------- | ----------------------------------------------------- |
| `LimitInt`   | `int`   | Limits an integer between a minimum and maximum value |
| `LimitFloat` | `float` | Limits a float between a minimum and maximum value    |
| `AddInt`     | `int`   | Adds multiple integers                                |
| `AddFloat`   | `float` | Adds multiple floating-point numbers                  |
| `SubInt`     | `int`   | Subtracts multiple integers                           |
| `SubFloat`   | `float` | Subtracts multiple floating-point numbers             |
| `MultiInt`   | `int`   | Multiplies multiple integers                          |
| `MultiFloat` | `float` | Multiplies multiple floating-point numbers            |
| `PowerInt`   | `int`   | Raises an integer to an integer power                 |
| `PowerFloat` | `float` | Raises a float to a power                             |
| `SquareRoot` | `float` | Calculates the square root of a number                |
| `Average`    | `float` | Calculates the average of multiple numbers            |

## Example

```csharp
using Common;

float average = CustomMath.Average(10f, 20f, 30f);
int total = CustomMath.AddInt(10, 20, 30);

Console.WriteLine(average); // 20
Console.WriteLine(total);   // 60
```

## Learning Goals

The main goal of this project is to improve my understanding of:

* C# fundamentals
* Methods and parameters
* `params`
* Arrays
* `foreach` and `for` loops
* Classes and namespaces
* Static methods
* Basic mathematical logic
* Building reusable code

## Status

This project is actively being developed as I learn more about C#.

The implementation may change over time as I learn better approaches and discover new mathematical operations.

## Project History

This project is a continuation of my C# learning journey.

## Actually..

This project originally started as a small experiment while working on a Unity game. I wanted to understand how Mathf.Clamp worked internally, so I decided to create my own version in pure C#.
While working on it, I kept adding more mathematical functions for practice, and the project gradually turned into a small mathematics library.
This is currently a one-day learning project and will probably continue to evolve as I learn more C#.

CustomMath is a more advanced version of that learning process, focusing on reusable mathematical functions and building a small library from scratch.

