namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Daxil edilən 3 ədədi müqayisə edin.(5, 8, 4 daxil edilibse 8 > 5 > 4 cap olunsun)

            while (true)
            {
                Console.Write("3 eded daxil edin daxil edin:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a > b && a > c && b > c) Console.WriteLine($"{a}>{b}>{c}");
                else if (a > b && a > c && c > b) Console.WriteLine($"{a}>{c}>{b}");
                else if (b > a && b > c && a > c) Console.WriteLine($"{b}>{a}>{c}");
                else if (b > a && b > c && c > a) Console.WriteLine($"{b}>{c}>{a}");
                else if (c > a && c > b && a > b) Console.WriteLine($"{c}>{a}>{b}");
                else if (c == a && c > b) Console.WriteLine($"{a}={c}>{b}");
                else if (c == a && b > c) Console.WriteLine($"{b}>{a}={c}");
                else if (c == b && c > a) Console.WriteLine($"{b}={c}>{a}");
                else if (c == b && a > c) Console.WriteLine($"{a}>{b}={c}");
                else if (a == b && a > c) Console.WriteLine($"{a}={b}>{c}");
                else if (a == b && c > a) Console.WriteLine($"{c}>{a}={b}");
                else if (a == b && a == c) Console.WriteLine($"{a}={b}={c}");
                else Console.WriteLine($"{c}>{b}>{a}");
            }
        }
    }
}