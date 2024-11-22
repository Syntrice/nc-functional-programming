namespace FunctionalProgramming
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

            //List<int> numbersAddTen = new List<int>();
            //numbers.ForEach((x) => { 
            //    var addedTen = Exercises001.AddTen(x);
            //    numbersAddTen.Add(addedTen);
            //});           //declaritive


            //for (int i = 0; i < numbersAddTen.Count; i++)             //imperative
            //{
            //    Console.WriteLine(numbersAddTen[i]);
            //}

            //List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            //words.ForEach(word => Console.WriteLine(Exercises001.GrammarCheck(word)));

            //Console.WriteLine(Exercises001.SumIndices("start", "pale"));

            ////Exercises002.GetUsernames();

            //var names = Exercises002.GetCoolPeople();
            //Exercises002.PrintCoolPeople(names);

            //List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
            //Exercises002.PrintSquareNums(numList);

            List<string> emailList = new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
                "link@hyrule.co.uk",
                "shrek@duloc.com",
                "neil.hughes@walkingoncustard.com",
                "csharp@microsoft.cs",
                "ziggy@spidersfrommars.co.uk",
                "lemmy@motorhead.co,uk",
                "me@myhouse.sleep"
            };

            var filteredEmails = Exercises002.FilterEmails(emailList);

            foreach (var item in filteredEmails)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(Console.WriteLine);
            }

        }
    }
}
