# Contributing

## Basics

When you work on anything please create an issue for it or comment on the appropriate issue thus people won't work on the same issues voiding their works.
Please make your issue very descriptive and describe what you are trying to achieve with it.

## Localizations

We do not support localizations yet. Although once we will anyone is welcome to help with it to make WolvenKit more avaliable for everyone.

## Bug reports

Please use the GitHub Issue tracker.

## Some local guidelines

### Frontend

WolvenKit uses **WPF** as framework for its GUI and we are using the **MVVM** pattern with ReactiveUI.

* `WolvenKit.csproj` is the WPF UI (it contains the Views)
* `WolvenKit.APP.csproj` is the platform-independent MVVM component (it contains the ViewModels)
* Prioritize constructor-injection with our DI (Splat)

WolvenKit is supposed to be an IDE-like app for developing mods - its UI should **prioritize function over form**. Visual Studio 2022 is considered the model.

### Code Style

The solution comes with an **editorconfig** file to use.

### Git

The `main` branch is the development branch. Releases are created by **tag**, hotfixes to releases are supposed to be branched-out from the tag. Branches should be created from a GitHub issue and should be focused, small and reviewable.

## General programming guidelines

We recommend to read through, and follow as closely as possible the Aviva C# Coding guidelines: [https://csharpcodingguidelines.com/](https://csharpcodingguidelines.com)

Due to practical reasons this won't be strictly enforced, however you should follow at least the following guidelines from Aviva 1.3:

* The Principle of Least Surprise (or Astonishment): you should choose a solution that everyone can understand, and that keeps them on the right track.
* Keep It Simple Stupid (a.k.a. KISS): the simplest solution is more than sufficient.
* You Ain't Gonna Need It (a.k.a. YAGNI): create a solution for the problem at hand, not for the ones you think may happen later on. Can you predict the future?
* Don't Repeat Yourself (a.k.a. DRY): avoid duplication within a component, a source control repository or a bounded context, without forgeting the Rule of Three heuristc. [https://en.wikipedia.org/wiki/Rule_of_three_(computer_programming)/](https://en.wikipedia.org/wiki/Rule_of_three_(computer_programming))
* The four principles of object-oriented programming: encapsulation, abstraction, inheritance and polymorphism. [http://codebetter.com/raymondlewallen/2005/07/19/4-major-principles-of-object-oriented-programming](http://codebetter.com/raymondlewallen/2005/07/19/4-major-principles-of-object-oriented-programming)

### As well as

* A class or interface should have a single purpose (**AV1000**)
* Classes should protect the consistency of their internal state (**AV1026**)
* Throw exceptions rather than returning some kind of status value (**AV1200**)
* Provide a rich and meaningful exception message text (**AV1202**)
* Name assemblies after their contained namespace (**AV1505**)
* Limit the contents of a source code file to one type (**AV1507**)
* Use using statements instead of fully qualified type names (**AV1510**)
* Don't use "magic" numbers (**AV1515**)
* Always add a block after the keywords if, else, do, while, for, foreach and case (**AV1535**)
* Build with the highest warning level (**AV2210**)

*See the PDF on [https://csharpcodingguidelines.com](https://csharpcodingguidelines.com) for details.*

### Additional points

* Avoid introducing new compiler warnings in your code.

## Code style

* Follow the general .NET naming conventions: [https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions)
* Put braces on their own lines:

    ~~~~csharp
    public void F()
    {
        // code
    }
    ~~~~

    Instead of using the K&R style:

    ~~~~csharp
    public void F() {
        // code
    }
    ~~~~
