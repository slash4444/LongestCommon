# LongestCommon
Challenge number 14 at leetcode

using System;: This line includes the System namespace, which contains classes and methods for basic input and output operations.

public class LongestCommonPrefixSolution { ... }: This code defines a C# class called LongestCommonPrefixSolution, which contains the method for finding the longest common prefix.

public string LongestCommonPrefix(string[] strs) { ... }: This is the main method for finding the longest common prefix among an array of strings. It takes an array of strings called strs as input and returns a string as the output.

if (strs == null || strs.Length == 0) { return ""; }: This line checks if the input array strs is null or empty. If it is, the function immediately returns an empty string, as there cannot be a common prefix in this case.

string commonPrefix = strs[0];: The code initializes a commonPrefix variable with the first string in the array. We start with the assumption that this string is the common prefix.

for (int i = 1; i < strs.Length; i++) { ... }: This loop iterates through the remaining strings in the strs array, starting from the second string (index 1).

string currentString = strs[i];: Inside the loop, we initialize a currentString variable with the string at the current index i.

int j = 0;: We initialize an index j to 0, which will be used to compare characters in the commonPrefix and currentString.

while (j < commonPrefix.Length && j < currentString.Length && commonPrefix[j] == currentString[j]) { j++; }: This while loop compares characters of the commonPrefix and currentString from left to right until it finds a character that doesn't match or until it reaches the end of one of the strings. The loop increments j with each matching character.

commonPrefix = commonPrefix.Substring(0, j);: After the loop, we update the commonPrefix to be the substring that contains only the matched characters up to index j. This ensures that commonPrefix always contains the longest common prefix found so far.

if (string.IsNullOrEmpty(commonPrefix)) { return ""; }: If at any point the commonPrefix becomes empty (meaning there is no common prefix), the function returns an empty string immediately.

Finally, after the loop has iterated through all the strings in the array, the function returns the commonPrefix, which is the longest common prefix among all the strings.
