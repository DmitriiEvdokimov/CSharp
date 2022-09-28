class Program
{
    static void Main (string [] args)
    {
        Console.WriteLine ("Нахождение максимального числа");
        Console.WriteLine ("Введите пять чисел:");
        Console.Write ("a=");
        string S1 = Console.ReadLine ();
        int a = int.Parse(S1);
        Console.Write ("b=");
        string S2 = Console.ReadLine ();
        int b = int.Parse(S2);
        Console.Write ("c=");
        string S3 = Console.ReadLine ();
        int c = int.Parse(S3);
        Console.Write ("d=");
        string S4 = Console.ReadLine ();
        int d = int.Parse(S4);
        Console.Write ("e=");
        string S5 = Console.ReadLine ();
        int e = int.Parse(S5);
        int max = a;
        if (max<b) max = b;
        if (max<c) max = c;
        if (max<d) max = d;
        if (max<e) max = e;

        Console.Write ("Max=");
        Console.WriteLine (max);
     }
 }
