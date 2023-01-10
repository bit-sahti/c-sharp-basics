namespace Studies
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(FahrenheitToCelsius(100));
            Console.WriteLine(GetSubstring("Hello World", 0, 5));
            Console.WriteLine(RepeatWord("a", 30));
            Console.WriteLine(GetDaysFromDate(new DateTime(2000, 1, 1)));
            Console.WriteLine(GetSumFromRange(1, 99));
        }

        public static int FahrenheitToCelsius(int fahrenheit)
        {
            return (int)Math.Round((fahrenheit - 32) * (5f / 9f));
        }

        public static string GetSubstring(string word, int start, int end)
        {
            return word.Substring(start, end);
        }

        public static string RepeatWord(string word, int times)
        {
            return String.Concat(Enumerable.Repeat(word, times));
        }

        public static string GetDaysFromDate(DateTime date)
        {
            return $"{(DateTime.Now - date).Days} have passed since {date.ToString("dd/MM/yyyy")}.";
        }

        public static int GetSumFromRange(int start, int end)
        {
            int result = 0;

            for (int i = start; i <= end; i++)
            {
                result += i;
            }

            return result;
        }
    }
}