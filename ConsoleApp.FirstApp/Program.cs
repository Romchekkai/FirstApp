using System;

class MainClass
{
    static void Main(string[] args)
    {
        

       var person = EnterUser();
        PrintUser(person);
    }


    static void PrintUser ((string name, string lastname, double age, bool haspet, int sumpet, string[] namepet, int sumcollors, string[] favcollors) user)
    {
        Console.WriteLine("Your name is: {0} {1}", user.name, user.lastname);
        Console.WriteLine("Your age is: {0}", user.age);
        
        for(int i = 0;i<user.sumpet; i++)
        {
            Console.WriteLine($"Your {i+1} pet is {user.namepet[i]}") ;// Дописать первый питомец такой то второй такой то как и первый цвет такой и тд
        }
        for(int i = 0; i<user.sumcollors; i++)
        {
            Console.WriteLine($"Your {i+1} favorite callor is {user.favcollors[i]}");
        }
    
    
    
    
    }
    static (string Name, string LastName, double Age, bool HasPet, int SumPet, string[] NamePet, int SumCollors, string[] FavCollors) EnterUser()
    {
        (string Name, string LastName, double Age, bool HasPet, int SumPet, string[] NamePet, int SumCollors, string[] FavCollors) User;
        Console.WriteLine("Введите имя");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");

        User.LastName = Console.ReadLine();
       

        string age;
        int intage;
        do
        {
            Console.WriteLine("Enter your age in numbers: ");
            age = Console.ReadLine();
        } while (ChekNum(age, out intage));
        User.Age = intage;

       
        Console.WriteLine("Есть ли у вас животные? Да или Нет");

        var result = Console.ReadLine();
        bool truepet;
        do
        {
            truepet = false;
            if ((result == "Да") || (result == "да"))
            {
                truepet = true;


            }
            else if ((result == "Нет") || (result == "нет"))
            {
                truepet = false;
            }
            else
            { 
                Console.WriteLine("Your answer is uncorrect, please try again");
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                result = Console.ReadLine();
            }
                                   
            

        } while ((result != "Да") && (result != "да") && (result != "Нет") && (result != "нет"));
        User.HasPet = truepet;

        if (User.HasPet)
        {
            string pet;
            int numpet;
            do
            {
                Console.WriteLine("Enter, How many pets do you have: ");
                pet = Console.ReadLine();
            }while (ChekNum(pet, out numpet));
            User.SumPet= numpet;
            User.NamePet=NamePets(User.SumPet);

        }
        else
        { User.SumPet =0;
            string[] nopet=new string[] { "No any pets" };
            User.NamePet = nopet;
        }

        string collor;
        int numcollor;
        do
        {
            Console.WriteLine("Enter, How many favorite collors do you have: ");
            collor = Console.ReadLine();
        } while (ChekNum(collor, out numcollor));
        User.SumCollors = numcollor;
        User.FavCollors = ShowCollor(numcollor);

        static string[] ShowCollor(int favcollor)
        {
            string[] collors = new string[favcollor];
            for (int i = 0; i < collors.Length; i++)
            {
                Console.WriteLine($"Enter your {i+1}th favorite collor: ");
                collors[i] = Console.ReadLine();
            }

            return collors;
        }
        static string[] NamePets(int Name)
        {
            string[] names = new string[Name];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine( $"Enter name {i+1} pet: ") ;
                names[i] = Console.ReadLine();
            }

            return names;
        }
        static bool ChekNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0) { corrnumber = intnum; return false; }

            }
            {
                corrnumber = 0;
                return true;

            }
        }

        return User;
    }
        
    
}

/*(string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

for (int k = 0; k < 3; k++)

{

    Console.WriteLine("Введите имя");
    User.Name = Console.ReadLine();

    Console.WriteLine("Введите фамилию");

    User.LastName = Console.ReadLine();

    Console.WriteLine("Введите логин");

    User.Login = Console.ReadLine();

    User.LoginLength = User.Login.Length;

    Console.WriteLine("Есть ли у вас животные? Да или Нет");

    var result = Console.ReadLine();

    if (result == "Да")
    {
        User.HasPet = true;
    }
    else
    {
        User.HasPet = false;
    }

    Console.WriteLine("Введите возраст пользователя");

    User.Age = double.Parse(Console.ReadLine());

    User.favcolors = new string[3];
    Console.WriteLine("Введите три любимых цвета пользователя");

    for (int i = 0; i < User.favcolors.Length; i++)
    {
        User.favcolors[i] = Console.ReadLine();
    }
}
*/
