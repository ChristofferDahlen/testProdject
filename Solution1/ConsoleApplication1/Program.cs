namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
        }

        public void OnEventOccuring(Event occuredEvent)
        {
            PerformAction();
            Console.WriteLine("ttta");
        }
    }

    internal class Event
    {
    }
}