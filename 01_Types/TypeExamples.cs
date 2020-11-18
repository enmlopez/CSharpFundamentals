using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16; //--Int16
            Int16 anotherSmallWholenumber = 16;
            int wholeNumber = 32;       //--Int32
            long largeWholeNumber = 64; //--Int64

            //--Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.237909d; //--d at the end optional
            decimal decimalExample = 1.234234m;

            //--Character
            char letter = 'j'; //--only one single character, #, special symbol


            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Strings 
            string stringExample = "This is a string."; //--Declaration and initialize
            string name = "Joshua";

            string declared;
            declared = "Now it is initialized.";


            //--Formatting strings
            string concatenate = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);


            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomTime = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomTime - now;
            Console.WriteLine(waitTime.TotalSeconds);


            //--Collections
            //--Arrays
            string anotherExamplestring = "Hello World";
            string[] stringArray = { anotherExamplestring, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(students);

            //--List
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //--Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //--Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //--Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();



        }
    }
}
