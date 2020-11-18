using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class InClassConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int studentCount = 16;
            if (studentCount >= 20)
            {
                Console.WriteLine("The class is getting pretty small");
            }
            else if (studentCount >=10)
            {
                Console.WriteLine("This class is really small");
            }
            else
            {
                Console.WriteLine("How many students do you have?");
            }

            switch (studentCount) //evaluate the value of SC 
            {
                case 12: //in the case it is exactly 12
                    Console.WriteLine("You have exactly 12 students");
                    break; //must break after case
                case 10:
                    Console.WriteLine("You have exactly 10 students");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("You have x number of students");
                    break;
                default: //if it is anything else then (default is true)
                    Console.WriteLine("How many students do you have?");
                    break;
            } 
            //Ternaries

            //if the value of this condition is 10 then condition is true otherwise it is false
            bool result = (studentCount == 10) ? true : false;
            //if the value of this condition is less than 65 then first statement otherwise second statement
            string isGoodSize = (studentCount < 65) ? "This class is manageable" : "Oh boy, that is a lot of students";
        }
    }
}
