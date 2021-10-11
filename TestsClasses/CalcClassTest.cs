using CalcClassBr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsClasses
{
    [TestClass]
    public class CalcClassTest
    {

        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HMV\Desktop\IT STEP ACADEMY\CommandProject\Exam\ExamGitHub\Calculator\TestsClasses\bin\Debug\CalcExamDB.mdf;Integrated Security=True;Connect Timeout=30", "DataForTest", DataAccessMethod.Sequential)]
        [TestMethod]
        public void MathOperationMetodTest()
        {

            int a = 0;
            if (TestContext.DataRow["a"] != DBNull.Value)
            {
                a = (int)TestContext.DataRow["a"];
            }
            int b = 0;
            if (TestContext.DataRow["b"] != DBNull.Value)
            {
                b = (int)TestContext.DataRow["b"];
            }

            string action = (string)TestContext.DataRow["action"];

            int expected = 0;
            if (TestContext.DataRow["result"] != DBNull.Value)
            {
                expected = (int)TestContext.DataRow["result"];
            }

            int actual = 0;
            try
            {
                switch (action)
                {
                    case "+ ":
                        actual = CalcClass.Add(a, b);
                        break;
                    case "- ":
                        actual = CalcClass.Sub(a, b);
                        break;
                    case "* ":
                        actual = CalcClass.Mult(a, b);
                        break;
                    case "/ ":
                        actual = CalcClass.Div(a, b);
                        break;
                    case "% ":
                        actual = CalcClass.Mod(a, b);
                        break;
                    case "+1":
                        actual = CalcClass.ABS(a);
                        break;
                    case "-1":
                        actual = CalcClass.IABS(a);
                        break;
                }
                Assert.AreEqual(expected, actual);

            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch (DivideByZeroException)
            {

            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionAdd()
        {
            CalcClass.Add(Int32.MaxValue, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionSub()
        {
            CalcClass.Sub(Int32.MinValue, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionMult()
        {
            CalcClass.Mult(Int32.MaxValue, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionDiv()
        {
            CalcClass.Div(((long)Int32.MaxValue + 1), 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionMod()
        {
            CalcClass.Mod(((long)Int32.MaxValue + 100), 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionABS()
        {
            CalcClass.ABS((long)Int32.MaxValue + 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionIABS()
        {
            CalcClass.IABS((long)Int32.MaxValue + 10);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            CalcClass.Div(5, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZeroMod()
        {
            CalcClass.Mod(5, 0);
        }

    }
}
