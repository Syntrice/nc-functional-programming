using FluentAssertions;
using FunctionalProgramming;
namespace FunctionalProgramming.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SquareItTest()
        {
            int input = 3;
            int expected = 9;

            int result = Exercises001.SquareIt(input);

            result.Should().Be(expected);
        }

        [Test]
        public void AddOneTest()
        {
            int input = 3;                          //arrange
            int expected = 4;

            int result = Exercises001.AddOne(input);        //act

            Assert.That(result == expected);        //assert

        }

        //[Test]
        [TestCase (1000000, TestName = "one million add ten")]
        
        public void AddTenTest(int input)
        {
            int expected = input + 10;

            Exercises001.AddTen(input).Should().Be(expected);
        }

        [Test]
        public void GrammarCheckTest()
        {
            List<string> input = [ "Arrange", "Act!", "assert!" ];

            Assert.Multiple(() =>
                {
                    Assert.That(Exercises001.GrammarCheck(input[0]) == false);
                    Assert.That(Exercises001.GrammarCheck(input[1]) == true);
                    Assert.That(Exercises001.GrammarCheck(input[2]) == false);
                });

        }
    }
}