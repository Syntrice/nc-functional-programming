using System.Threading.Channels;

namespace FunctionalProgramming
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string> {"rich.neat@boardgamer.com",
                                                                                    "poppy.mcdonnell@irishdancer.com",
                                                                                    "neil.hughes@walkingoncustard.com",
                                                                                    "alice.yang@midfielder.com",
                                                                                    "pippa.austin@musician.com"};
        public static Action GetUsernames = () => {
            var namesList = GetCoolPeople();
            namesList.ForEach(name => Console.WriteLine(name.Split('@')[0]));
        };
    }
}
