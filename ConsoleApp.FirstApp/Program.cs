using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);
        Console.WriteLine("What is your birthday?");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthday is {0}", birthdate);

    }
}