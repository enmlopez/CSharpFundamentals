using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_MethodsToErase
{
    [TestClass]
    public class Methods
    {

        //input
        //What we do
        //Output

        //Access Modifier ----Return type----Method Signature (Nme and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainer(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;

        }
        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int SubtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, SubtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainer(10, 4);
            Assert.AreEqual(2, remainder);


        }
    }
}
