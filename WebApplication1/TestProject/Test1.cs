using WebApplication1;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void TestAdd()
        {
            //Arrange
            int a = 7;
            int b = 4;
            int expected = 11;


            //Act
            Calculator c = new Calculator();

            int actual = c.add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}