using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Program
    {

        private static int Task1(string incomingString)
        {
            //Counter used to count string chars
            int count = 0;

            foreach(char c in incomingString)
            {
                //increment the counter when e is found in c
                if (c == 'e') count++;
            }
            return count;
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

        private static string Task3a(string[] stringArray, string stringToCheck)
        {
            //Counter used to count string chars
            int cat = 0; int dog = 0; int large = 0;


            //Each value within array string
            foreach (string x in stringArray)
            {
                //Check is the string contains a value from string array
                if (stringToCheck.Contains(x))
                {
                    //If its a cat then increment the cat integer
                    if (x == "cat") cat++;
                    //If its a dog then increment the dog integer
                    if (x == "dog") dog++;
                    //If its a large then increment the large integer
                    if (x == "large") large++;
                }
            }

            //Create a total by adding all values
            int total = cat + dog + large;

            //Create a return string
            string returnValue = "Cat: " + cat + " Dog: " + dog + " Large: " + large + " Tatal = " + total;

            //Return the string
            return returnValue;
        }

        private static void Censored(string[] stingOfWords, string[] strArry1, string[] strArry2, bool fullStopEnd)
        {
            //Loop starting from 0 to the total amount of words stored in stringOfWords
            for (int i = 0; i < stingOfWords.Count(); i++)
            {
                //Loop starting from 0 to the total amount of words stored in strArry1
                for (int j = 0; j < strArry1.Count(); j++)
                {
                    //If the word and string array of value match
                    if (stingOfWords[i].ToLower() == strArry1[j].ToLower())
                    {
                        //Then swap the value with the string array value 2. (Censored value)
                        stingOfWords[i] = strArry2[j];
                    }
                }
                //Print the word with a space

                string lastWord = stingOfWords[stingOfWords.Length - 1];
                if (stingOfWords[i] == lastWord && fullStopEnd == true)
                {
                    Console.Write(stingOfWords[i] +  ".");
                }
                else
                {
                    Console.Write(stingOfWords[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("TASK 1");
            int task1Output = Task1("I have some cheese");
            Console.WriteLine("input: {0}", "I have some cheese");
            Console.WriteLine("output (e's found) : {0}", task1Output);

            //Task 2
            Console.WriteLine("\nTASK 2");
            Console.WriteLine("input: {0}", "God saved Eva’s dog");
            Console.WriteLine("output : {0}", IsPalindrome("God saved Eva’s dog"));

            //Task 3a
            Console.WriteLine("\nTASK 3A");
            string stringToCheck = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
            string[] stringArray = { "cat", "dog", "large" };
            Console.WriteLine("input: {0}", stringToCheck);
            Console.WriteLine("output: {0}", Task3a(stringArray, stringToCheck));

            //Task 3b
            Console.WriteLine("\nTASK 3B");
            string tsk3b_sentence = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
            Console.WriteLine("input: {0}", tsk3b_sentence);
            Console.Write("output: ");
            //Split the sentence when it finds a fullstop.
            string[] splitSentences = tsk3b_sentence.Split('.');
                //Split setence 1 to words when a whitespace is found
            string[] splitSentencesToWords = splitSentences[0].Split(' ');
            string[] b_strArry1 = new string[] { "moew", "woof" };
            string[] b_strArry2 = new string[] { "m**w", "w**f" };
                
            Censored(splitSentencesToWords, b_strArry1, b_strArry2, true);
            Console.Write(splitSentences[1] + "." + splitSentences[2] + ".");

            //Task 3c
            Console.WriteLine("\n\nTASK 3C");
            string tsk3c_sentence = "Anna went to vote in the election to fulfil her civic duty";
            Console.WriteLine("input: {0}", tsk3c_sentence);
            string[] splitWords = tsk3c_sentence.Split(' ');
            Console.Write("output: ");

            //Create a string of array values { anna, civic }
            //These will be replaced with the values in strArray2
            string[] c_strArry1 = new string[] { "anna", "civic" };
            string[] c_strArry2 = new string[] { "A**a", "c**c" };
            Censored(splitWords, c_strArry1, c_strArry2, false);

            //Task 3d
            Console.WriteLine("\n\nTASK 3D");
            Console.WriteLine("1. You can provide a censored world list to the application by taking in arguments");
            Console.WriteLine("2. You can provide a censored world list to the application by taking in a console input");
            Console.ReadLine();
        }
    }
}
