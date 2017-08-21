using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuture.CodingTest.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest.Tests.Tests
{
    [TestClass()]
    public class Task1Tests
    {

        [TestMethod()]
        public void CountNumberOfLettersTest()
        {
            string str = "I have some cheese";
            char _letter = 'e';
            Task1 _task1 = new Task1(str, _letter);

            _task1.CountNumberOfLetters();

            Assert.AreEqual(5, _task1.count);
        }

        [TestMethod()]
        public void checkPalindromeTest()
        {
            string sentence = "God saved Eva’s dog";
            Task2 _task2 = new Task2(sentence);

            _task2.checkPalindrome();
            Assert.AreEqual(true, _task2.isPalindome);
        }
    }
}