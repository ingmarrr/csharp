namespace Calendar
{
    /// <summary>
    /// This class will ask the user for the name of the event, the location, the start date, the end date, and the cost per day.
    /// Then it will calculate the duration of the event and the total cost and display the information to the user.
    /// </summary>
    public class Event
    {
        private string name;
        private string location;
        private DateTime startTime;
        private DateTime endTime;

        private double duration;

        private double costPerDay;

        /// <summary>
        /// This method starts the collection of data from the user. It will change the console title and display a greeting.
        /// Then it will collect all the necessary data and display it back to the user.
        /// </summary>
        public void Start()
        {
            Console.Title = "My Event";
            Console.WriteLine("\nGreetings from the Event class!\n");

            ReadInput();
            CalculateDuration();
            DisplayEventInfo();
        }

        /// <summary>
        /// Reads the name of the event, the location, the start date, the end date, and the cost per day from the user
        /// and saves it in the corresponding fields.
        /// </summary>
        private void ReadInput()
        {
            name = Cli.Ask("What is the name of the event? ");
            location = Cli.Ask("Where is the event? ");
            startTime = Cli.AskDateTime("What day does the event start? ");
            endTime = Cli.AskDateTime("What day does the event end? ");
            costPerDay = Cli.AskDouble("What is the cost per day? ");
        }

        /// <summary>
        /// Calculates the duration of the event based on the start date and the end date.
        /// </summary>
        private void CalculateDuration()
        {
            duration = (endTime - startTime).TotalDays;
        }

        /// <summary>
        /// Displays the event information to the user. 
        /// It also calculates the total cost based on the duration and the cost per day.
        /// </summary>
        private void DisplayEventInfo()
        {
            const string format = "dd/MM/yyyy";
            Console.WriteLine($"Event Name: {name}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Start Date: {startTime.ToString(format)}");
            Console.WriteLine($"End Date: {endTime.ToString(format)}");
            Console.WriteLine($"Duration: {duration} days");
            Console.WriteLine($"Cost: {costPerDay * duration:C}");
        }
    }
}