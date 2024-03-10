using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1_laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp1_laba2.Form1;

namespace WinFormsApp1_laba2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void FirstTest()
        {
            string inputWidht = "12";
            string inputHeight = "5";

            string expectedMessage = "Квадраты имеют размерности: 5 5 2 2 1 1 \nКоличество квадратов: 6\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void SecondTest()
        {
            string inputWidht = "-1";
            string inputHeight = "5";

            string expectedMessage = "Ошибка ввода\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void ThirdTest()
        {
            string inputWidht = "hello";
            string inputHeight = "goodbye";

            string expectedMessage = "Ошибка ввода\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}


/*namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FirstTest()
        {
            string inputWidht = "12";
            string inputHeight = "5";

            string expectedMessage = "Квадраты имеют размерности: 5 5 2 2 1 1 \nКоличество квадратов: 6\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void SecondTest()
        {
            string inputWidht = "-1";
            string inputHeight = "5";

            string expectedMessage = "Ошибка ввода\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void ThirdTest()
        {
            string inputWidht = "hello";
            string inputHeight = "goodbye";

            string expectedMessage = "Ошибка ввода\n";

            string actualMessage = Logic.Compare(inputWidht, inputHeight);

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}*/