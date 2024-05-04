namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello, how are you";
            Console.WriteLine("space's in sentence: " + spaces(sentence));
        }
        public static int PrintTwoNumbersResult(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public static int Printnumbersquare(int a)
        {
            int result = a * a;
            return result;
        }
        public static int PrintSumArrayElements(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void PrintWelcomeMessage(string name, string surname)
        {
            Console.WriteLine($"Xos gelmisen, {name} {surname}");
        }
        public static string ReversedWord(string word)
        {
            string reversedWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
                reversedWord += word[i];

            return reversedWord;
        }
        static void DividedBy7(int num)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine($"{num} is divided by 7");
            }
            else
            {
                int nextMultiple = ((num / 7) + 1) * 7;
                int prevMultiple = (num / 7) * 7;
                int closestNumber;

                if (nextMultiple - num < num - prevMultiple)
                {
                    closestNumber = nextMultiple;
                }
                else
                {
                    closestNumber = prevMultiple;
                }

                Console.WriteLine($"{num} is not divisible by 7, the closest one is: {closestNumber}");
            }
        }
        public static int FindPerimetr(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int FindPerimetr(int a)
        {
            return 4 * a;
        }
        static int spaces(string sentence)
        {
            int space = 0;
            foreach (char character in sentence)
            {
                if (char.IsWhiteSpace(character))
                {
                    space++;
                }
            }
            return space;
        }
    }
}
