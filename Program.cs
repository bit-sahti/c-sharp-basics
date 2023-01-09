namespace Studies
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(FahrenheitToCelsius(100));
            Console.WriteLine(GetSubstring("Hello World", 0, 5));
            Console.WriteLine(RepeatWord("a", 30));
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
    }
}