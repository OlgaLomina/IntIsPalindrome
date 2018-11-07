using System;
/*Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

Input: 121
Output: true
Example 2:

Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
Follow up:

Coud you solve it without converting the integer to a string?
 * */
namespace Pal_Int1
{
    public class Program
    {
        static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int temp = 0, a = 0, b = x;
            while (b != 0)
            {
                a = b % 10;
                b = b / 10;
                temp = temp * 10 + a;
            }

            if (temp == x)
                return true;
            else
                return false;

        }

        static void Main(string[] args)
        {
            int val = -121;
            if (IsPalindrome(val))
                Console.WriteLine("It is a palindrome");
            else
                Console.WriteLine("It is NOT a palindrome");
        }
    }
}
