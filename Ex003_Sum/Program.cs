class Program
{   
        static void Main(string[] args)
    {
        Console.WriteLine ("Сумма двух чисел");
        Console.WriteLine ("Введите первое число:");
        string S1 = Console.ReadLine();
        int x = int.Parse(S1);
        Console.WriteLine ("Введите второе число:");
        string S2 = Console.ReadLine();
        int y = int.Parse(S2);
        int result = x + y;
        Console.Write ("Результат:");
        Console.WriteLine (result);
    }
}