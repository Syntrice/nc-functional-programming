using FluentAssertions;
using FunctionalProgramming;
namespace FunctionalProgramming.Tests
{
    public class Exercises002Tests
    {
        [Test]
        public void GetEmailList_ShouldReturnCorrectEmails()
        {
            List<string> emailList = Exercises002.GetCoolPeople();

            emailList.Should().BeEquivalentTo(new List<string>
            {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.com",
                "pippa.austin@musician.com"
            });
        }

        [Test]
        public void SquaredNums_ShouldSquareNumbersInPlace()
        {
            List<int> numList = new List<int> { 5, 8, 3, 6, 67 };   //arrange
            List<int> expectedNums = new List<int> { 25, 64, 9, 36, 4489 };

            Exercises002.SquaredNums(numList);                      //act

            numList.Should().BeEquivalentTo(expectedNums);          //assert
        }


        [Test]
        public void FilterEmails_ShouldFilterByDomain()
        {
            List<string> input = new List<string>
            {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.co.uk",
                "pippa.austin@musician.blah.blah"
            };

            Dictionary<string, List<string>> expectedOutput = new Dictionary<string, List<string>>()
            {
                { ".com", ["rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com", "neil.hughes@walkingoncustard.com"]},
                { ".co.uk", ["alice.yang@midfielder.co.uk"]},
                {"invalid", ["pippa.austin@musician.blah.blah"] }
            };

            Exercises002.FilterEmails(input).Should().BeEquivalentTo(expectedOutput);
        }
    }
}
