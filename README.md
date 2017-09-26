# CSharpYieldReturn

    Explore some neat syntactic sugar in C#: "yield return" for enumerators

C# has a really neat feature for implementing enumerators: *yield return*.  This
reminds me of lazy list evaluation in Clojure.  It sure removes a lot of clutter!

This project was developed on Windows 10 with .NET Core. The initiaal version
of the *dotnet* utility I'm used was 1.0.0-preview2-003131. Later I upgraded
to dotnet 1.1.0, and then to dotnet 2.0.


# Build and Run

If necessary, install the .NET Core 2.0 SDK, from http://dot.net.

Clone the project. To build and run from the command line, 

1. ```cd yield```
2. ```dotnet restore```
3. ```dotnet build```
4. ```dotnet run```

Alternatively, if you have Visual Studio 2017, open the solution file ```YieldReturn.sln`` and build the
solution.
