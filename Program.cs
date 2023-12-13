using System;

namespace intro
{
    internal class Program
    {
        static string Seasons(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Error";
            }
        }

        static void Main(string[] args)
        {
            //1
            int num = int.Parse(Console.ReadLine());
            if (num < 1 && num > 100)
            {
                Console.WriteLine("Out of range");
            }

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(num);
            }

            //2
            double num1 = int.Parse(Console.ReadLine());
            double precentage = int.Parse(Console.ReadLine());
            double res = num1 * (precentage / 100);
            Console.WriteLine(res);

            //3
            string line = "";
            for (int i = 0; i < 4; i++)
            {
                line += Console.ReadLine();
            }
            int num3 = int.Parse(line);
            Console.WriteLine(num3);
            //4

            Console.WriteLine("Enter 6 - digits number: ");
            string line1 = Console.ReadLine();
            if (line1.Length != 6)
            {
                Console.WriteLine("Error: number should contain 6 digits");
            }
            int first_index = int.Parse(Console.ReadLine()) - 1;
            int second_index = int.Parse(Console.ReadLine()) - 1;
            char[] arr = line1.ToArray();
            char tmp = arr[first_index];
            arr[first_index] = arr[second_index];
            arr[second_index] = tmp;
            int number = int.Parse(arr);
            Console.WriteLine(number);
            //5
            Console.WriteLine("Enter date: ");
            string date_str = Console.ReadLine();
            var list = new List<int>(3);
            foreach (string part in date_str.Split('.'))
            {
                int part_int = int.Parse(part);
                list.Add(part_int);
            }
            int[] date_arr = list.ToArray();
            DateOnly date = new DateOnly(date_arr[2], date_arr[1], date_arr[0]);
            Console.WriteLine(Seasons(date_arr[1]));
            Console.WriteLine(date.DayOfWeek);

            //6
            Console.WriteLine("Enter degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose measurement system:\n1 - Fahrenheit to Celsius\n2 - Celsius to Fahrenheit");
            int choise = int.Parse(Console.ReadLine());
            string result = "";
            switch (choise)
            {
                case 1:
                    result = ((degree - 32) * 5 / 9).ToString();
                    break;
                case 2:
                    result = ((degree * 9 / 5) + 32).ToString();
                    break;
                default:
                    result = "Wrong choise";
                    break;
            }
            Console.WriteLine(res);

            //7
            Console.WriteLine("Enter 1 number: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                int start = n2;
                n2 = n1;
                n1 = start;
            }
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}