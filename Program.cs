class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском языке с маленькой буквы");

        var color = Console.ReadLine ();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Ваш любимый цвет Красный!");

        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Ваш любимый цвет Зеленый!");

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ваш любимый цвет не опознан!");
        }

        
    }
}