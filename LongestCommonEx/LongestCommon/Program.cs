using System;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        // Start with the first string as the initial common prefix
        string commonPrefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            string currentString = strs[i];
            int j = 0;

            // Compare characters of the current string with the common prefix
            while (j < commonPrefix.Length && j < currentString.Length && commonPrefix[j] == currentString[j])
            {
                j++;
            }

            // Update the common prefix to the matched portion
            commonPrefix = commonPrefix.Substring(0, j);

            // If commonPrefix becomes empty, there's no common prefix
            if (string.IsNullOrEmpty(commonPrefix))
            {
                return "";
            }
        }

        return commonPrefix;
    }

    public static void Main(string[] args)
    {
        string[] strs1 = { "flower", "flow", "flight" };
        LongestCommonPrefixSolution solution = new LongestCommonPrefixSolution();
        string result1 = solution.LongestCommonPrefix(strs1);
        Console.WriteLine(result1); // Output: "fl"

        string[] strs2 = { "dog", "racecar", "car" };
        string result2 = solution.LongestCommonPrefix(strs2);
        Console.WriteLine(result2); // Output: ""
    }
}
