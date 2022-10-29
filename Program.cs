using System;
namespace Program
{
    class Program
    {
        static string GetFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial.ToString();
        }

        public static string[] CreateNewArray(string[] array)
        {
            string result = "";

            foreach (var item in array)
            {
                if (int.TryParse(item, out int intNum))
                    result += $"{GetFactorial(intNum)} ";
                else if (int.TryParse(item, out int numNum) && int.Parse(item) <= 0)
                    result += $"{numNum} ";
                else if (double.TryParse(item, out double doubleNum))
                    result += $"{Math.Abs((int)(Math.Round(doubleNum, 2) * 100 % 100))} ";
            }
            return result.Split(' ');
        }

        public static void PrettyPrint(string[] array)
        {
            string result = "";

            foreach (var item in array)
            {
                result += $"{item} ";
            }

            Console.WriteLine($"[{result.Trim()}]");
        }
        public static void Main()
        {
            Console.Write("Введите числа через пробел: ");
            string line = Console.ReadLine();

            string[] array = line.Split(' ');
            string[] newArray = CreateNewArray(array);

            PrettyPrint(array);
            PrettyPrint(newArray);
        }
    }
}