# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#.  The `swap` function attempts to swap two mutable variables, but due to the way F# handles variable scope, the swap does not occur in the outer scope.

## Bug Description
The `bug.fs` file contains code that attempts to swap two mutable integer variables.  The expected behavior is that the values of `x` and `y` are swapped after calling the `swap` function. However, the actual behavior is that the variables remain unchanged. This is because the `swap` function is operating on local copies of the variables, not the original variables.

## Solution
The `bugSolution.fs` file provides a corrected version of the code. It utilizes tuples to achieve the desired swap, avoiding the scope issues that the original code experienced.  Using tuples helps maintain the correct behavior as there is no direct modification of external variables through the swap function.

## How to Reproduce
1. Clone this repository.
2. Open `bug.fs` and compile and run the code. Observe the unexpected output.
3. Open `bugSolution.fs`, compile, and run the code. Observe the corrected output.
