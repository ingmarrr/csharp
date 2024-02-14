using System.Data;
using System.Globalization;

public class Cli
{
    /// <summary>
    /// Ask a question and return the string answer. Will poll the user until a non-empty answer is entered.
    /// </summary>
    /// <param name="question"></param>
    /// <returns>User Answer</returns>
    public static string Ask(string question)
    {
        do
        {
            Console.Write(question);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("You did not provide an answer.");
            }
        } while (true);
    }

    /// <summary>
    /// Ask a question and return an integer as the answer. Will poll the user until a valid integer is entered.
    /// </summary>
    /// <param name="question"></param>
    /// <returns></returns>
    public static int AskInt(string question)
    {
        do
        {
            Console.Write(question);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("You did not enter an integer.");
                }
            }
            else
            {
                Console.WriteLine("You did not enter an integer.");
            }
        } while (true);
    }

    /// <summary>
    /// Ask a question and return a double as the answer. Will poll the user until a valid double is entered.
    /// </summary>
    /// <param name="question"></param>
    /// <returns></returns>
    public static double AskDouble(string question)
    {
        do
        {
            Console.Write(question);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("You did not enter a double.");
                }
            }
            else
            {
                Console.WriteLine("You did not enter a double.");
            }
        } while (true);
    }

    /// <summary>
    /// Ask a question and return a decimal as the answer. Will poll the user until a valid decimal is entered.
    /// </summary>
    /// <param name="question"></param>
    /// <returns></returns>
    public static DateTime AskDateTime(string question)
    {
        const string format = "dd/MM/yyyy";
        do
        {
            Console.Write(question + $" (format: {format}) ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (DateTime.TryParseExact(input, format, null, DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"You did not enter a date in the format {format}.");
                }
            }
            else
            {
                Console.WriteLine($"You did not enter a date in the format {format}.");
            }
        } while (true);
    }

    /// <summary>
    /// Ask a question and return a decimal as the answer. Will poll the user until a valid decimal is entered.
    /// </summary>
    public static void Wait()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.WriteLine();
    }
}