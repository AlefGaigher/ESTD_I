using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Recursividade");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(fibo(i));
        }        
    }
    public static int fibo(int n)
    {
        if (n > 1)
        {
            return fibo(n - 1) + fibo(n - 2);
        }
        else
        {
            return 1;
        }
    }

    public static int fat(int n)
    {
        if(n > 1)
        {
            return n * fat(n-1);
        }
        else
        {
            return 1;
        }
    }
}