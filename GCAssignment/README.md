# Garbage Collection Assignment

This project demonstrates the use of **destructors** (`finalizers`) and the **IDisposable** interface in C#.

The solution is structured around three tasks, but the work is split into **two commits** to clearly show progress:

---

## Commit 1 — Tasks 1 & 2

- **Task 1: `Play`**
  - Stores: title, author’s full name, genre, year.
  - Input validation.
  - Implements a **destructor** (`~Play`) to demonstrate finalization.
  - Tested in `Program.cs`.

- **Task 2: `Shop`**
  - Stores: name, address, type (enum: Groceries, Household, Clothing, Footwear).
  - Implements **IDisposable**.
  - Cleanup shown via:
    - Explicit `Dispose()`.
    - `using` statement (calls `Dispose()` automatically).
  - Tested in `Program.cs`.

  ---

## Commit 2 — Task 3

- **`Play`** now also implements **IDisposable** (full dispose pattern **with** destructor).
- **`Shop`** is extended with a **destructor** in addition to IDisposable.
- `Program.cs` shows both paths:
  - Best practice: `using` → deterministic `Dispose()`; finalizer suppressed.
  - Demo: "forgotten" objects created in a helper method, then `GC.Collect()` + `GC.WaitForPendingFinalizers()` to **visually demonstrate** finalizers.

---