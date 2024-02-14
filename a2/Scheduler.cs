
namespace Apps
{
    public static class Scheduler
    {

        public static void Start()
        {
            var menuItems = new Cli.Item[]
            {
                new(1, "Show a list of weekends to work"),
                new(2, "Show a list of nights to work"),
                new(3, "Show a list of weekends to work (custom interval)"),
                new(4, "Show a list of nights to work   (custom interval)"),
                new(0, "Exit")
            };

            for (var ok = true; ok;)
            {
                ok = Cli.AskChoice(menuItems) switch
                {
                    0 => false,
                    1 => Weeks(2, 50, 2),
                    2 => Weeks(1, 51, 4),
                    3 => Weeks(Cli.AskInt("Start week: "), Cli.AskInt("Number of weeks: "), 2),
                    4 => Weeks(Cli.AskInt("Start week: "), Cli.AskInt("Number of weeks: "), 4),
                    _ => true
                };
            }
        }

        private static bool Weeks(int start, int end, int incr)
        {
            Cli.WriteSubTitle("Weeks");
            var i = 0;
            for (var week = start; week <= start + end; week += incr)
            {
                Console.Write($"Week {week,2}");
                Console.Write(++i % 4 == 0 ? "\n" : "\t\t");
            }
            Console.WriteLine();
            return true;
        }
    }
}