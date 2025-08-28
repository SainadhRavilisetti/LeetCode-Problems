public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder str1 = new StringBuilder();

        // Check if the input array is empty
        if (strs.Length == 0) return "";

        // If there's only one string, return it as the longest common prefix
        if (strs.Length == 1) return strs[0];

        // Iterate through the characters of the first string
        for (int i = 0; i < strs[0].Length; i++)
        {
            char currentChar = strs[0][i];

            // Check if this character is present at the same position in all strings
            for (int j = 1; j < strs.Length; j++)
            {
                // If we reach the end of any string or the characters do not match
                if (i >= strs[j].Length || strs[j][i] != currentChar)
                {
                    return str1.ToString(); // Return the current prefix
                }
            }

            // If the character is common, append it to the StringBuilder
            str1.Append(currentChar);
        }

        return str1.ToString(); // Return the longest common prefix
    }
}