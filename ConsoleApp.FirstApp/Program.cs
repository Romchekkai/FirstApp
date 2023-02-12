using System;

class MainClass
{
    public static void Main(string[] args)
    {
        
        
        
        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
        for( int q = 0;q<3;q++)
        {  
            Console.WriteLine("Введите имя");

        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");

        User.LastName = Console.ReadLine();

        Console.WriteLine("Введите логин");

        User.Login = Console.ReadLine();

        User.LoginLength = User.Login.Length;
        Console.WriteLine($"Длинна вашего логина {User.LoginLength}");

        Console.WriteLine("Do you have a pet? Yes or No:");
        var ispet = Console.ReadLine();
        if(ispet == "Yes")
        {
            User.HasPet= true;
        }
        else { User.HasPet= false; }
        Console.Write("Введите возраст: ");
       User.Age = (Convert.ToDouble(Console.ReadLine()));
        User.favcolors = new string[3] ;
        Console.WriteLine("Введите три любимых цвета пользователя");

        for( int i =0; i < User.favcolors.Length; i++ ) { User.favcolors[i] = Console.ReadLine(); }

        }

    }
}


