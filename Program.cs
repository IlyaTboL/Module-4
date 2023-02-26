class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском языке с маленькой буквы");

        var color = Console.ReadLine ();

        switch(color) 
        {
            case "red":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Ваш любимый цвет Красный!");
                break;

            case "green":
        
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Ваш любимый цвет Зеленый!");
                break;

        
        default: 
        
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ваш любимый цвет не опознан!");
                break;
        }

        
    }
}