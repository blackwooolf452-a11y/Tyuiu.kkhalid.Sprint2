using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kkhalid.Sprint2.Task5.V8.Lib;

namespace Tyuiu.Kkhalid.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay1()
        {
            DataService ds = new DataService();
            int m = 3;
            int n = 15;
            string wait = "14.3";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay2()
        {
            DataService ds = new DataService();
            int m = 5;
            int n = 1;
            string wait = "30.4";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay3()
        {
            DataService ds = new DataService();
            int m = 1;
            int n = 2;
            string wait = "1.1";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay4()
        {
            DataService ds = new DataService();
            int m = 3;
            int n = 1;
            string wait = "28.2";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}