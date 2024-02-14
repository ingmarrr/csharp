
public class Cli
{
    public static void WriteTitle(string title)
    {
        Console.Title = title;
        WriteGroup(title, '+');
    }

    public static void WriteSubTitle(string title)
    {
        WriteGroup(title, '-', 5);
    }

    public static void WriteGroup(string text, char symbol = '=', int count = 10)
    {
        Console.WriteLine();
        Console.WriteLine($"{new(symbol, count)} {text} {new(symbol, count)}");
        Console.WriteLine();
    }

    public static string Ask(string question)
    {
        do
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            if (answer != "" && answer != null)
            {
                return answer;
            }
            Console.WriteLine("Please enter a value.");
        } while (true);
    }

    public static int AskInt(string question)
    {
        do
        {
            var answer = Ask(question);
            if (int.TryParse(answer, out int result))
            {
                return result;
            }
            Console.WriteLine("Please enter a valid integer.");
        } while (true);
    }

    public static bool AskBool(string question)
    {
        return Ask(question).ToLower() switch
        {
            "y" or "yes" => true,
            "n" or "no" => false,
            _ => AskBool(question)
        };
    }

    public record Item(int Id, string Name);

    public static int AskChoice(Item[] menuItems)
    {
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("              Main Menu               ");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        foreach (var item in menuItems)
        {
            Console.WriteLine("    {0, -35}: {1}", item.Name, item.Id);
        }
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++\n");
        return Cli.AskInt("Your choice: ");
    }
}