
namespace Apps
{
    record Span(int Start, int End)
    {
        public int Min() => Math.Min(Start, End);
        public int Max() => Math.Max(Start, End);
    }

    public static class MathWorks
    {
        public static void Calculate()
        {
            Span nums = new(
                Cli.AskInt("Enter a start number: "),
                Cli.AskInt("Enter an end number: ")
            );

            Cli.WriteSubTitle("Sum Numbers");
            SumNumbers(nums);

            Cli.WriteSubTitle("Even Numbers");
            EvenNumbers(nums);

            Cli.WriteSubTitle("Calculate Square Root");
            CalculateSquareRoot(nums);

            Cli.WriteSubTitle("Odd Numbers");
            OddNumbers(nums);

            ExitCalculation();
        }

        private static void SumNumbers(Span nums)
        {
            var sum = 0;
            for (var i = nums.Min(); i <= nums.Max(); i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from {nums.Min()} to {nums.Max()} is {sum}");
        }

        private static void EvenNumbers(Span nums)
        {
            var even = new List<int>();
            for (var i = nums.Min(); i <= nums.Max(); i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
            }
            Console.WriteLine($"The even numbers from {nums.Min()} to {nums.Max()} are {string.Join(", ", even)}");
        }

        private static void OddNumbers(Span nums)
        {
            var odd = new List<int>();
            for (var i = nums.Min(); i <= nums.Max(); i++)
            {
                if (i % 2 != 0)
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine($"The odd numbers from {nums.Min()} to {nums.Max()} are {string.Join(", ", odd)}");
        }

        private static void CalculateSquareRoot(Span nums)
        {
            var squareRoots = new List<double>();
            for (var i = nums.Min(); i <= nums.Max(); i++)
            {
                for (var j = i; j <= nums.Max(); j++)
                {
                    squareRoots.Add(Math.Sqrt(i));
                }
                Console.WriteLine($"Sqrt({i,3} to {nums.Max(),3}) = {string.Join(", ", squareRoots.Select(x => x.ToString("F2")))}");
                squareRoots.Clear();
            }
        }

        private static void ExitCalculation()
        {
            if (!Cli.AskBool("Do you want to exit? (y/n) "))
            {
                Calculate();
            }
        }
    }
}