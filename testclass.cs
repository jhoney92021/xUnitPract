using Xunit;
namespace test
{

    public class testclass
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]

        public void MyFirstTheory(int myNum)
        {
            Assert.True(Program.IsOdd(myNum));
        }

        [Fact]
        public void PassingAddTest()
        {
            Assert.Equal(4, Program.Add(2,2));

        }

        [Fact]

        public void FailingTest()
        {
            Assert.NotEqual(5, Program.Add(2,2));
        }
    }
}