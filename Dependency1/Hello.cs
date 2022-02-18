namespace Dependency1
{
    using MoreLinq;

    public class Say
    {
        public static void Hello()
        {
            var version = new List<int>().Prepend(1).First();
            System.Console.WriteLine($"  Dependency {version}");
        }
    }
}