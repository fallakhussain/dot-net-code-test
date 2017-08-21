using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest.Tests
{
    public class Task2
    {
        public bool isPalindome;
        public string sentence;

        public Task2(string str)
        {
            sentence = str;
        }

        public void checkPalindrome()
        {
            isPalindome = IsPalindrome(sentence);
        }

        public static bool IsPalindrome(string str)
        {
            //This will be used to start check using first char
            int min = 0;
            //This will be using to start check using last char
            int max = str.Length - 1;

            //Continues loop, while it is true.
            //Loops out when the return is false.
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = str[min];
                char b = str[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = str[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = str[max];
                }

                //No match for lowercase, get out of the loop.
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                //Increment minimum value and dicrement max value
                min++;
                max--;
            }
        }

    }
}
