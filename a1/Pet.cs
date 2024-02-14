

namespace Pet
{
    /// <summary>
    /// Asks for information about your pet and displays it back to you.
    /// </summary>
    public class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        /// <summary>
        /// This method starts the collection of data from the user. It will change the console title and display a greeting.
        /// Then it will collect all the necessary data and display it back to the user.
        /// </summary>
        public void Start()
        {
            Console.Title = "My Pet";
            Console.WriteLine("\nGreetings from the Pet class!\n");

            ReadAndSavePetData();
            DisplayPetInfo();
        }

        /// <summary>
        /// Asks the user for the name, age and gender of the pet and saves it in the corresponding fields.
        /// </summary>
        private void ReadAndSavePetData()
        {
            name = Cli.Ask("What is the name of your pet? ");
            age = Cli.AskInt("How old is your pet? ");
            isFemale = Cli.Ask("Is your pet female? (y/n) ").ToLower().StartsWith('y');
        }

        /// <summary>
        /// Displays the pet information to the user.
        /// </summary>
        private void DisplayPetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.WriteLine((isFemale ? "She" : "He") + " is a wonderful pet!");
        }
    }
}