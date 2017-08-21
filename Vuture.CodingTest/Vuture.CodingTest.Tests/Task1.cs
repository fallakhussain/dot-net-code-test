using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest.Tests
{
    public class Task1
    {
        public string sentence;
        public char letter;
        public int count;

        public Task1(string incomingString, char letterToCount)
        {
            sentence = incomingString;
            letter = letterToCount;
        }

        public int CountNumberOfLetters(string incomingString, char letterToCount)
        {
            //Counter used to count string chars
            int count = 0;

            foreach (char c in incomingString)
            {
                //increment the counter when e is found in c
                if (c == letterToCount) count++;
            }
            return count;
        }

        public void CountNumberOfLetters()
        {
            //Counter used to count string chars
            int _count = 0;

            foreach (char c in sentence)
            {
                //increment the counter when e is found in c
                if (c == letter) _count++;
            }
            count = _count;
        }
    }


}
