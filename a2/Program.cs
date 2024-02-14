
using Apps;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperatureConverter.Start();
            ContinueToNextPart("String Functions");
            StringFunctions.Start();
            ContinueToNextPart("Math Works");
            MathWorks.Calculate();
            ContinueToNextPart("Scheduler");
            Scheduler.Start();
        }

        private static void ContinueToNextPart(string title)
        {
            Console.WriteLine("\nPress Enter to continue to the next part...");
            Console.ReadLine();
            Console.Clear();
            Console.Title = title;
            Console.WriteLine("+++++++++++++ {0} +++++++++++++", title);
        }
    }
}
