namespace Dependency2
{
    using MoreLinq;

    public class Say
    {
        public static void Hello()
        {
            Dependency1.Say.Hello();

            var version = new List<int>().Prepend(2).First();
            System.Console.WriteLine($"  Dependency {version}");
        }
    }
}