using System.Text;
using System.Text.RegularExpressions;
namespace Studies
{
    class Program
    {
        public static void Main()
        {
            // Console.WriteLine(FahrenheitToCelsius(100));
            // Console.WriteLine(GetSubstring("Hello World", 0, 5));
            // Console.WriteLine(RepeatWord("a", 30));
            // Console.WriteLine(GetDaysFromDate(new DateTime(2000, 1, 1)));
            // Console.WriteLine(GetSumFromRange(1, 99));
            Console.WriteLine(RemoveVowels("hEllo"));
            Console.WriteLine(RemoveVowelsRegex("hEllo"));
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

        public static string RemoveVowels(string word)
        {
            string vowels = "aiueo";

            StringBuilder result = new StringBuilder();

            foreach (char letter in word)
            {
                if (!vowels.Contains(Char.ToLower(letter))) result.Append(letter);
            }

            return result.ToString();
        }

        public static string RemoveVowelsRegex(string word)
        {
            return Regex.Replace(word, "[aiueo]", "", RegexOptions.IgnoreCase);
        }
    }
}