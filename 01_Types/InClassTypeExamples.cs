using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 32;

            byte someByte = 23;

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.2345346;
            float someFloat = 23.234325f;
            decimal someDecimal = 23.3425325m;

            char letter = 'm';
            bool trueOrFalseValue = true;
        }

        [TestMethod]
        public void ReferencesTypes()
        {
            string randomCharacters = "aldsag 34653 @ # .";
            string specialCharacters = "\"Michael\"";
            string otherSpecialCharacters = "\n"; //line return
            Console.WriteLine(specialCharacters);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan age = DateTime.Now - new DateTime(1990, 08, 26);
            Console.WriteLine(age);

            string[] names = { "Casey", "Michael", "Simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 324325235.325; //changing the value in the key value pair.

            Console.WriteLine(fruits[0]); //Index starts at 0
            Console.WriteLine(dictionary['x']);
        }
    }
}
