namespace FunctionalProgramming
{
    public class ListManager
    {
        public List<string> Names { get; set; }

        public ListManager(List<string> names)
            { this.Names = names; } 

        public List<string> Filter(Predicate<string> predicate)
        {
            return Names.Where(name => predicate(name)).ToList();
        }
    }
}
