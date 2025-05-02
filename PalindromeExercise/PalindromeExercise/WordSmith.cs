using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public static bool IsAPalindrome(string word)
    {
        var lowerCaseWord = word.ToLower();
        var reverseWord = new string(lowerCaseWord.Reverse().ToArray());
        if (reverseWord == lowerCaseWord)
        {
            return true;
        }
        return false;
    }
}