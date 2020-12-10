# Integer Array Puzzle [![Build Status](https://dev.azure.com/nerada/GitHub/_apis/build/status/Nerada.challenges_intArrayPuzzle?branchName=master)](https://dev.azure.com/nerada/GitHub/_build/latest?definitionId=9&branchName=master)

(Airtame_001) Submit your solution by committing them into this git repository.

### Challenge (2-3 hours)
You are given a list of integers, which may be both positive and negative. Each integer in the list must either be paired with another element in the list or be a single element. Once the elements have been paired, the integers in the pairs are multiplied and the results are summed up - the sum will include the single elements.

Write a program to find the biggest possible sum.

###### Examples:
- For the list `[0,1,2,3,4,5]` the pairs `(4,5)` and `(2,3)` are formed and `0` and `1` are single elements. The max sum is `27`: `(20+6+0+1)`.

- For the list `[-1,0,1]` the pair `(-1,0)` is formed and `1` is a single element. The max sum is `1`.

- For the list `[1,1]` no pairs are formed -- only two single elements. The max sum is `2`.

You are free to choose the implementation language and how input/output is handled.
