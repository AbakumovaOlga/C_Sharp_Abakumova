using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SS3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3Tests
{
    [TestClass]
    public class SS3Test
    {
        [TestMethod]
        public void hasFreeTest()
        {
            //arrange
            int[,] matr = new int[,] { { 1, 0, 1 }, { 0, 1, -1 }, { 0, 1, 0 } };
            bool expected = true;

            //act
            PlayContext c = new PlayContext();
            Play p = new Play(3, c);

            bool actual = p.hasFree(matr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isWinTest()
        {
            //arrange
            int[,] matr = new int[,] { { 1, 0, 1 }, { 0, 1, -1 }, { 0, 1, 0 } };
            bool expected = false;

            //act
            PlayContext c = new PlayContext();
            Play p = new Play(3, c);

            bool actual = p.isWin(matr);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void getListTest2()
        {
            // Arrange
            PlayContext c = new PlayContext();
            PlayStub playFake = new PlayStub();
            Play play = new Play(3, c);
            string expected = "Общая Победа X";

            // Act
            var list = playFake.getList();
            string actual = play.allWinner(list);

            //Assert 
            //Assert.IsNotNull(list);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getListTest3()
        {
            // Arrange
            PlayContext c = new PlayContext();
            PlayStub playFake = new PlayStub();
            Play p = new Play(3, c);
            var list = playFake.getList();
            string expected = "Общая Победа X";

            /*var mock = new Mock<IPlay>();
            mock.Setup(pl => pl.getList()).Returns(list);
            */

            IPlay play = Mock.Of<IPlay>(d => d.getList() == list);//



            //Act
            /*var listres = mock.Object.getList();*/
            var listres = play.getList();//
            string actual = p.allWinner(list);

            //Assert
            //Assert.IsNotNull(listres);
            Assert.AreEqual(expected, actual);
        }
    }
}
