# largest-sibling-number

Two non-negative integers are called siblings if they can be obtained from each other by
rearranging the digits of their decimal representations. For example, 123 and 213 are
siblings. 535 and 355 are also siblings.
A set consisting of a non-negative integer N and all of its siblings is called the family of
N. For example, the family of 553 comprises three numbers: 355, 535 and 553.
Write a function with the following inputs and outputs:
● input: N (integer)
● output: integer
That, given a non-negative integer N, returns the largest number in the family of N. The
function should return -1 if the result exceeds 100,000,000.
As an example, a C# answer for this exercise could have the following format:
 int solution(int N);
Inputting N=213 to this function should return 321. For N=553, the function should
return 553.
Assume that:
● N is an integer within the range [0..2,147,483,647].
Complexity:
● Expected worst-case time complexity is O(N);
● Expected worst-case space complexity is O(N).