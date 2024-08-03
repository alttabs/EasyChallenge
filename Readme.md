# TwistedFizzBuzz Solution

This solution contains a multi-project setup for the TwistedFizzBuzz library, which includes:

- A class library `TwistedFizzBuzzLibrary` that implements the FizzBuzz logic.
- Two console applications `StandardFizzBuzzApp` and `CustomFizzBuzzApp` that demonstrate the usage of the TwistedFizzBuzz library.
- A test project `TwistedFizzBuzzTests` for unit testing the TwistedFizzBuzz library.

## Solution Structure

```
TwistedFizzBuzzSolution
│
├── TwistedFizzBuzzLibrary
│   └── TwistedFizzBuzz.cs
│
├── StandardFizzBuzzApp
│   └── Program.cs
│
├── CustomFizzBuzzApp
│   └── Program.cs
│
└── TwistedFizzBuzzTests
    └── TwistedFizzBuzzTests.cs
```

## Getting Started

### Setup Instructions

1. Clone the repository:

```sh
git clone <repository-url>
cd TwistedFizzBuzzSolution
```

2. Restore and build the solution:

```sh
dotnet restore
dotnet build
```

## Projects

### 1. TwistedFizzBuzzLibrary

This is the core library that contains the FizzBuzz logic. It can:
- Accept user input for a range of numbers and return their FizzBuzz output.
- Accept user input of a non-sequential set of numbers and return their FizzBuzz output.
- Accept user input for alternative tokens instead of "Fizz" and "Buzz" and alternative divisors instead of 3 and 5.

### 2. StandardFizzBuzzApp

A console application that uses the TwistedFizzBuzz library to solve the standard FizzBuzz problem.

#### Usage

```sh
dotnet run --project StandardFizzBuzzApp
```

### 3. CustomFizzBuzzApp

A console application that uses the TwistedFizzBuzz library to:
- Output values from -20 to 127
- For multiples of 5 print "Fizz"
- For multiples of 9 print "Buzz"
- For multiples of 27 print "Bar"
- For multiples where more than one number from above matches, print the appropriate concatenated tokens

#### Usage

```sh
dotnet run --project CustomFizzBuzzApp
```

### 4. TwistedFizzBuzzTests

This project contains unit tests for the TwistedFizzBuzz library using xUnit.

#### Running Tests

```sh
dotnet test
```