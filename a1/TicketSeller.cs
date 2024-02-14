

namespace TicketSeller
{
    /// <summary>
    /// This class will ask the user for their name, the number of adults, and the number of children and
    /// then it will calculate the amount to pay and display a ticket. It contains a constant for the price
    /// of a ticket and a constant for the discount for children.
    /// </summary>
    public class TicketSeller
    {
        private string name;
        private int numOfAdults;
        private int numOfChildren;

        private double amountToPay;

        private const double price = 10.0;
        private const double childDiscount = 0.25;

        /// <summary>
        /// This method starts the collection of data from the user. It will change the console title and display a greeting.
        /// Then it will collect all the necessary data and display it back to the user.
        /// </summary>
        public void Start()
        {
            Console.Title = "My Ticket Seller";
            Console.WriteLine("\nGreetings from the TicketSeller class!\n");

            ReadInput();
            CalculateAmountToPay();
            DisplayTicket();
        }

        /// <summary>
        /// Reads the name of the user, the number of adults, and the number of children from the user 
        /// and saves it in the corresponding fields.
        /// </summary>
        private void ReadInput()
        {
            name = Cli.Ask("What is your name? ");
            numOfAdults = Cli.AskInt("How many adults? ");
            numOfChildren = Cli.AskInt("How many children? ");
        }

        /// <summary>
        /// Calculates the amount to pay based on the number of adults, the number of children, 
        /// the price of a ticket, and the discount for children.
        /// </summary>
        private void CalculateAmountToPay()
        {
            amountToPay = numOfAdults * price + numOfChildren * price * childDiscount;
        }

        /// <summary>
        /// Displays the ticket to the user.
        /// </summary>
        private void DisplayTicket()
        {
            Console.WriteLine(" +++ Your Receipt +++");
            Console.WriteLine($" +++ Amount to pay = {amountToPay:C} +++");
            Console.WriteLine($" +++ Price per Ticket = {price:C} +++");

            Console.WriteLine($"\n +++ Thank you {name} for your purchase! +++");
        }
    }
}
