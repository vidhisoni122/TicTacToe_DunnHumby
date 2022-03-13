using NUnit.Framework;
using TicTacToe_DunnHumby.Helpers;

namespace TicTacToe.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1_ArrayLength_CheckWin()
        {
            char[] arr = {  'X', 'X', 'X' };

            int flag = arr.CheckWin();

            Assert.AreEqual(-1,flag);
        }

        [Test]
        [TestCase(new [] { '0', 'X', 'X', 'X', '4', '5', '6', '7', '8', '9' })]
        [TestCase(new [] { '0', '1', '2', '3', 'X', 'X', 'X', '7', '8', '9' })]
        [TestCase(new [] { '0', '1', '2', '3', '4', '5', '6', 'X', 'X', 'X' })]
        public void Test2_Horizontal_CheckWin(char[] arr)
        {           
            int flag = arr.CheckWin();

            Assert.AreEqual(1, flag);
        }

        [Test]
        [TestCase(new[] { '0', 'X', 'O', 'O', 'X', '5', '6', 'X', '8', '9' })]
        [TestCase(new[] { '0', 'O', 'X', '3', 'O', 'X', '6', 'O', 'X', '9' })]
        [TestCase(new[] { '0', '1', 'O', 'X', '4', 'O', 'X', '7', 'O', 'X' })]
        public void Test2_Verticle_CheckWin(char[] arr)
        {
            int flag = arr.CheckWin();

            Assert.AreEqual(1, flag);
        }

        [Test]
        [TestCase(new[] { '0', 'X', '2', '3', '4', 'X', '6', '7', '8', 'X' })]
        [TestCase(new[] { '0', '1', '2', 'X', '4', 'X', '6', 'X', '8', '9' })]
        public void Test2_Diagonal_CheckWin(char[] arr)
        {
            int flag = arr.CheckWin();

            Assert.AreEqual(1, flag);
        }

        [Test]
        [TestCase(new[] { '0', 'X', 'O', 'X', 'O', 'X', 'O', 'O', 'X', 'O' })]
        public void Test2_Draw_CheckWin(char[] arr)
        {
            int flag = arr.CheckWin();

            Assert.AreEqual(-1, flag);
        }

        [Test]
        [TestCase(new[] { '0', 'X', '2', 'X', 'O', 'X', 'O', 'O', 'X', 'O' })]
        public void Test2_Invalid_CheckWin(char[] arr)
        {
            int flag = arr.CheckWin();

            Assert.AreEqual(0, flag);
        }

    }
}