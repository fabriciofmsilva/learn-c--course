# Acceptance Criteria

AS a user I would like to be able to probide a file containing the Sudoku puzzle and as a result either receive the solution or a message letting me know that ir cannot be solved.

It is not required for it to solve 100% of the puzzles, however it should be architected in such a way that it could be enhanced easily.

## Example:

| Input                   | Output                                                                                            |
| ----------------------- | ------------------------------------------------------------------------------------------------- |
| File containing         | When filename is invalid show error message                                                       |
| Sudoku Puzzle           | When filename is valid and Sudoku Puzzle cannot be solved show it cannot be solved                |
|                         | When filename is valid and Sudoku Puzzle can be solved show the initial state and the final state |
