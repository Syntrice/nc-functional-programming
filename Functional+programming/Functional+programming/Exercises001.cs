namespace FunctionalProgramming
{


    public class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;

        public static Func<int, int> SquareIt = num => num * num;

        public static Func<int, int> AddTen = num => num + 10;

        public static Predicate<string> GrammarCheck = str => str[0] == 'A' && str[^1] == '!';

        public static Func<string, string, int> SumIndices = (word1, word2) =>
        {
            return word1.ToLower().IndexOf('a') + word2.ToLower().IndexOf('e');
        };

        public static string CheckValidEmail(string email)
        {

            Predicate<string> isNorthCoders = email => email.Split('@')[1] == "northcoders.co.uk";
            Predicate<string> usernameFiveOrMore = email => email.Split('@')[0].Length >= 5;

            if (isNorthCoders(email) && usernameFiveOrMore(email))
            {
                return "Email domain and user valid, please continue";
            }
            else
            {
                return "Email domain and user name invalid, please check your input";
            }


        }


    }
}