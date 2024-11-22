namespace FunctionalProgramming
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string> 
        {
            "rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",                                            
            "pippa.austin@musician.com"
        };

        public static Action GetUsernames = () =>
        {
            var namesList = GetCoolPeople();
            namesList.ForEach(name => Console.WriteLine(name.Split('@')[0]));
        };

        public static Action<List<string>> PrintCoolPeople = list => list.ForEach(name =>
        {
            Console.WriteLine(name);
        });

        public static Action<List<int>> SquaredNums = list =>
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] * list[i];
            }
        };

        public static Action<List<int>> PrintNums = list => list.ForEach(Console.WriteLine);
        public static Action<List<int>> PrintSquareNums = list =>
        {
            SquaredNums(list);
            PrintNums(list);
        };

        public static Dictionary<string, List<string>> FilterEmails(List<string> list)
        {
            Dictionary<string, List<string>> emailsByExtension = new Dictionary<string, List<string>>();

            String[] filterDomains = [".co.uk", ".com"];

            foreach (string domain in filterDomains)
            {
                emailsByExtension.Add(domain, list.Where(email => email.Contains(domain)).ToList());
            }

            emailsByExtension.Add("invalid", list.Where(email => !filterDomains.Any(extension => email.Contains(extension))).ToList());

            return emailsByExtension;
        }
    }
}