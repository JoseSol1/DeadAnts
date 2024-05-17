using NUnit.Framework;
using System;

namespace DeadAntsProy
{
    public class DeadAntsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_NullInput()
        {
            string input = null;
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2_NoAnts()
        {
            string input = ".....";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test3_OnlyAliveAntes()
        {
            string input = "antantant";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test4_MixedAntes()
        {
            string input = "ant anantt aantnt";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test5_SpacesDots()
        {
            string input = "ant ant .... a nt";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test6_EmptyInput()
        {
            string input = "";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test7_InvalidAntRepresentation()
        {
            string input = "ant ant ant banana";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test8_LargeInputSize()
        {
            string input = new string('a', 1000000);
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test9_SpecialCharactersInInput()
        {
            string input = "ant ant @#%&^ a nt";
            int result = Kata.DeadAntCount(input);
            Assert.AreEqual(1, result);
        }
    }
}
