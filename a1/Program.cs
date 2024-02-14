using Pet;

namespace ConsoleApps
{
    /// <summary>
    /// This is the main entry point for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is the main entry point for the application. It will call the Start() method of each class.
        /// </summary>
        public static void Main(string[] args)
        {
            SetupConsole();
            new Pet.Pet().Start();

            Cli.Wait();
            new TicketSeller.TicketSeller().Start();

            Cli.Wait();
            new Album.Album().Start();

            Cli.Wait();
            new Calendar.Event().Start();
        }

        /// <summary>
        /// This method sets up the console window. It will set the windows background color to white and the text color to black.
        /// </summary>
        static void SetupConsole()
        {
            Console.Title = "My Console Classes";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
