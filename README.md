# DELEGATES EXAMPLE

This repository serves as an example project for .NET Community in SDE Software Solutions, s.r.o.
The purpose of the repository is to show an examples of delegates usage in C#.

## Table of Contents

- [Requirements](#requirements)
- [Usage](#usage)
- [Running specific methods](#running-specific-methods)
- [Table of example methods](#table-of-example-methods)

## Requirements

All You need to run this project is .NET 5 SDK or higher

## Usage

One option is to run `dotnet run` in Your teminal

The other is to run a new instance directly from the IDE


## Running specific example

In order to run a specific example You need to make a simple change in `Program.cs`:

For synchronous methods change the argument in the `Action` for Your required [method](#table-of-example-methods):
```cs
var runMethod = new Action(Example1.Run);
            runMethod();
```

For asynchronous methods change the argument in the `Func` for Your required [method](#table-of-example-methods):

```cs
var runMethodAsync = new Func<Task>(TestExampleFixed.RunAsync);
            await runMethodAsync();
```

## Table of example methods

| Synchronous methods          	| Asynchronous methods      	|
|------------------------------	|---------------------------	|
| AnonymousMethodExample.Run   	| TestExample.RunAsync      	|
| DeclareDelegateExample.Run   	| TestExampleFixed.RunAsync 	|
| FuncActionExample.Run        	|                           	|
| MulticastDelegateExample.Run 	|                           	|
| StudentExamExample.Run       	|                           	|