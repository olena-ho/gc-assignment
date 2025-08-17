# Garbage Collection Assignment

This project demonstrates the use of **destructors** (`finalizers`) and the **IDisposable** interface in C#.

The solution is structured around three tasks, but the work is split into **two commits** to clearly show progress:

---

## Commit 1 — Tasks 1 & 2

- **Task 1: Class `Play`**
  - Stores play information: title, author’s full name, genre, and year.
  - Includes validation for input values.
  - Implements a **destructor** (`~Play`) to demonstrate how finalizers are called by the Garbage Collector.
  - Tested in `Program.cs`.

- **Task 2: Class `Shop`**
  - Stores shop information: name, address, and type (enum: Groceries, Household, Clothing, Footwear).
  - Implements the **IDisposable** interface.
  - Demonstrates resource cleanup through:
    - `Dispose()` called explicitly.
    - `Dispose()` called automatically via the `using` statement.
  - Tested in `Program.cs`.