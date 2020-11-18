using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            //For loop
            //declare an integer = 0 ; test the condition is i <= 10
            for (int i = 0; i <= studentCount; i++) //i = i + 1
            {
                Console.WriteLine(i);
            }

            string[] names = { "Michael", "Simon", "Peyton", "Casey" };
            Console.WriteLine(names); // doesn't give us individual strings

            foreach (string name in names) //for each string (x) in names
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length); //count the number of items in the array

            while (studentCount >0)
            {
                Console.WriteLine(studentCount);
                studentCount--; //studentCound = studenCount - 1
            }
        }
    }
}
