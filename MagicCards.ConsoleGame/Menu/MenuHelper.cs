namespace MagicCards.ConsoleGame.Menu;

public class MenuHelper
{
    public static void ExecuteMenu(List<MenuOptions> options)
    {
        int index = 0;
        PrintMenu(options, index);
        ConsoleKeyInfo keyInfo;

        do
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (index + 1 < options.Count)
                {
                    index++;
                }
            }

            PrintMenu(options, index);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (index - 1 >= 0)
                {
                    index--;
                }

                PrintMenu(options, index);
            }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                options[index].Action();
                index = 0;

                PrintMenu(options, index);
            }

        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    private static void PrintMenu(List<MenuOptions> options, int index = 0)
    {
        Greeting();

        for (int i = 0; i < options.Count; i++)
        {
            Console.SetCursorPosition(50,i+3);
            MenuOptions option = options[i];

            if (i == index)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"(>) {option.Title} (<)");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(option.Title);
            }

        }
    }

    private static void Greeting()
    {
        Console.Clear();
        Console.SetCursorPosition(45,0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("Welcome to The Sorcery Fight");
        MenuHelper.DrawHorizontalLine();        
        Console.ResetColor();
    }

    public static void DrawHorizontalLine()
    {
        for (int i = 0; i < Console.BufferWidth; i++)
        {
            Console.Write('=');
        }
    }
}