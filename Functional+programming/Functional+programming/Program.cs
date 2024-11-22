namespace Functional_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

            List<int> numbersAddTen = numbers.Select(Exercises001.AddTen).ToList();
            numbersAddTen.ForEach(Console.WriteLine);           //declaritive

            for (int i = 0; i < numbersAddTen.Count; i++)             //imperative
            {
                Console.WriteLine(numbersAddTen[i]);
            }

        }
    }
}
