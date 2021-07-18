using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using L9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTime()
        {
            Time expectedTime = new Time(6, 50);
            Time t = new Time(0, 0);
            t.Hours = 5;
            t.Minutes = 110;
            Assert.AreEqual(t.Hours, expectedTime.Hours);
            Assert.AreEqual(t.Minutes, expectedTime.Minutes);
        }
        [TestMethod]
        public void TestAddTime()
        {
            Time expectedTime = new Time(6, 50);
            Time t1 = new Time(5, 10);
            Time t2 = new Time(1, 40);
            Time t = new Time();
            t = Time.AddTime(t1, t2);
            Assert.AreEqual(t.Hours, expectedTime.Hours);
            Assert.AreEqual(t.Minutes, expectedTime.Minutes);
        }
        [TestMethod]
        public void TestAddTimeMethod()
        {
            Time expectedTime = new Time(6, 50);
            Time t1 = new Time(5, 10);
            Time t2 = new Time(1, 40);
            Time t = new Time();
            t = t1.AddTimeMethod(t2);
            Assert.AreEqual(t.Hours, expectedTime.Hours);
            Assert.AreEqual(t.Minutes, expectedTime.Minutes);
        }
        [TestMethod]
        public void P()
        {
            Time expectedTime = new Time(6, 50);
            Time t1 = new Time(6, 49);
            t1++;
            Assert.AreEqual(t1.Minutes, expectedTime.Minutes);
        }
        [TestMethod]
        public void M()
        {
            Time expectedTime = new Time(6, 50);
            Time t1 = new Time(6, 51);
            t1--;
            Assert.AreEqual(t1.Minutes, expectedTime.Minutes);
        }
        [TestMethod]
        public void IntTest()
        {
            int expectedTime = 2;
            Time t1 = new Time(2, 12);
            Assert.AreEqual((int)t1, expectedTime);
        }
        [TestMethod]
        public void BoolTest()
        {
            bool expectedTime = true;
            Time t1 = new Time(6, 12);
            Assert.AreEqual((bool)t1, expectedTime);
        }
        [TestMethod]
        public void PTest()
        {
            Time expectedTime = new Time(6, 50);
            Time t1 = new Time(5, 10);
            Time t2 = new Time(1, 40);
            Time t = t1 + t2;
            Assert.AreEqual(t.Hours, expectedTime.Hours);
            Assert.AreEqual(t.Minutes, expectedTime.Minutes);
        }        
        [TestMethod]
        public void MTest()
        {
            Time expectedTime = new Time(3, 30);
            Time t1 = new Time(5, 10);
            Time t2 = new Time(1, 40);
            Time t = t1 - t2;
            Assert.AreEqual(t.Hours, expectedTime.Hours);
            Assert.AreEqual(t.Minutes, expectedTime.Minutes);
        }                
        [TestMethod]
        public void AverageTest()
        {
            TimeArray ta = new TimeArray(5, true);
            double average = ta.Average();
            Assert.AreEqual(average, 4291.4);
        }
        [TestMethod]
        public void IndexatorTest()
        {
            TimeArray ta2 = new TimeArray();
            TimeArray ta = new TimeArray(5, true);
            Time testTime = new Time(5, 20);
            ta[0] = testTime;
            Assert.AreEqual(testTime, ta[0]);
        }
    }
}
