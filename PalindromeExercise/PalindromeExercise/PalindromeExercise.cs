using System;

namespace PalindromeExercise
{

        public class WordSmith
        {
            public bool IsAPalindrome(string str)
            {
            var reverse = "";

                for (int i = str.Length -1; i >= 0; i--)
                {
                reverse += str[i];
                }

            if (reverse.ToLower() == str.ToLower()) return true;
            return false;
            }
        }
    
}
