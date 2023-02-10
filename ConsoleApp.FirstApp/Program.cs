using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        bool switcherend = true;
        while (switcherend)
        {
            
            var color=Console.ReadLine();
            if (color != "stop" )
            { 
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is cyan!");
                    break;
                

                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
            }
            Console.WriteLine("Напишите другой цвет на английском с маленькой буквы");
            }
            else { switcherend=false; }
        }
    }
}