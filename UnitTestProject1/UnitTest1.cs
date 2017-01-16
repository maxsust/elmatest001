using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using C = Calc; 

namespace UnitTestProject1
{
    // <summary>
    // тестирование  Calc
    // </summary>
    [TestClass] // класс тестер
    public class CalcUnitTest
    {
        [TestMethod]  // метод тестер
        public void SumTest()
        {
            var calc = new C.Calc();
            var result = calc.Sum(1, 2);
            Assert.AreEqual(result, 3); 
        }
    }
}
