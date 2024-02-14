namespace Apps
{
    public static class StringFunctions
    {
        public static void Start()
        {
            RunAgain();
        }

        static void RunAgain()
        {
            for (var ok = true; ok;)
            {
                StringLength();
                PredictMyDay();
                ok = Cli.AskBool("\nRun again? [y/n] ");
            }
        }

        static void StringLength()
        {
            Cli.WriteSubTitle("String Length");
            var input = Cli.Ask("Enter a string: ");
            Console.WriteLine($"\n{input.ToUpper()}\nNumber of characters: {input.Length}");
        }

        static void PredictMyDay()
        {
            Cli.WriteSubTitle("Predict My Day");
            Console.WriteLine("\n" + Cli.AskInt("Let me predict your day. Enter a number between 1 and 7: ") switch
            {
                1 => "Keep calm on Mondays! You can fall apart!",
                2 => "Tuesdays and Wednesdays break your heart!",
                3 => "Thursday is your lucky day, don't wait for Friday!",
                4 => "Friday, you are in love!",
                5 => "Saturday, do nothing and do plenty of it!",
                6 => "And Sunday always comes too soon!",
                7 => "No day? A good day but it doesn't exist!",
                _ => "Thats not a valid day :( ... [1-7]"
            });
        }
    }
}