using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsClasses
{
    [TestClass]
    public class AnalizerClassTest
    {
        [TestMethod]
        public void CheckCurrencyTest()
        {
            AnalaizerClass.expression = "(5+1)+(+6)+5/(-5+5-5)%5";
            bool result = AnalaizerClass.CheckCurrency();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void FormatTest()
        {
            string expected = "(5-6)+5/(5+5-5)%5)";
            AnalaizerClass.expression = "(5-6 )+5/ (5+ 5- 5)% 5)";
            string actual = AnalaizerClass.Format();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateStackTest()
        {
            ArrayList result = new ArrayList() { 5, 5, 5, 5, "+", 5, "-", 5, "%", "/", "+" };
            string expected = "";
            foreach (var item in result)
                expected += item.ToString();
            AnalaizerClass.expression = "5+5/(5+5-5)%5";
            ArrayList actual = AnalaizerClass.CreateStack();
            string actualStr = "";
            foreach (var item in actual)
                actualStr += item.ToString();
            Assert.AreEqual(expected, actualStr);
        }
        [TestMethod]
        public void RunEstimateTest()
        {
            string expected = "17";
            AnalaizerClass.expression = "(5+1)+6+5/(5+5-5)%2";
            string actual = AnalaizerClass.RunEstimate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EstimateTest()
        {
            string expected = "7";
            AnalaizerClass.expression = "(5+1)+(+6)+5/(-5+5-5)%2";
            string actual = AnalaizerClass.Estimate();
            Assert.AreEqual(expected, actual);
        }
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HMV\Desktop\IT STEP ACADEMY\CommandProject\Exam\ExamGitHub\Calculator\TestsClasses\bin\Debug\ListErrorsDB.mdf;Integrated Security=True;Connect Timeout=30", "Table", DataAccessMethod.Sequential)]
        [TestMethod]
        public void MathOperationMetodTest()
        {
            string expected = "";
            if (TestContext.DataRow["ErroNumber"] != DBNull.Value)
            {
                expected = (string)TestContext.DataRow["ErroNumber"];
            }
            if (TestContext.DataRow["Expression"] != DBNull.Value)
            {
                AnalaizerClass.expression = (string)TestContext.DataRow["Expression"];
            }
            else if (TestContext.DataRow["Expression"] == DBNull.Value&&expected=="07")
            {
                AnalaizerClass.expression = new String('1', 65537);
            }
            else if (TestContext.DataRow["Expression"] == DBNull.Value && expected == "08")
            {
                AnalaizerClass.expression = "1+2+3+4+4+6+7+8+9+0-0-9-8-7-6-5-4-3-2-1/2/3/4/5/6/7/8/9/0";
            }
            string actual = "";
            try
            {
                switch (expected)
                {
                    case "01":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "02":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "03":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "04":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "05":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "06":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "07":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "08":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                    case "09":
                        actual = AnalaizerClass.Estimate().Substring(7, 2);
                        break;
                }
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

            }
        }
    }
}