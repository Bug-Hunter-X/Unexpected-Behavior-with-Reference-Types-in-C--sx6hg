# Unexpected Behavior with Reference Types in C#

This repository demonstrates a common pitfall in C# programming involving the unintuitive behavior of reference types.  When you assign a reference type variable to another variable, both variables point to the same object in memory.  Modifying the object through one variable will change the object for all variables referencing it.

This can lead to unexpected results, especially in multi-threaded applications or situations where the codebase is large and the relationship between different parts of the application isn't immediately obvious.

The `bug.cs` file shows the problematic code and `bugSolution.cs` provides a solution using value types or cloning techniques, depending on the desired outcome.