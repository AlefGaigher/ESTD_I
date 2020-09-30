using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat gato1 = new Cat();
            gato1.name = "Oscar";
            gato1.gender = 'm';
            gato1.age = 5;
            gato1.hungry = true;

            gato1.Eat();
            gato1.Meow();
            Console.WriteLine($"Name:{gato1.name}, Fome:{gato1.hungry} ");
        }
    }
}
