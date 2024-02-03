using MagicCards.ConsoleGame.GameElements;

namespace MagicCards.ConsoleGame.Menu
{
    public class MainMenu
    {
        public static List<MenuOptions> MainMenuOptions = new List<MenuOptions>()
        {
            new MenuOptions()
            {
                Title = "Start Game",
                Action = OnStart,
            },
            new MenuOptions()
            {
                Title = "Exit",
                Action = OnExit,
            },
        };

        private static void OnStart()
        {
            Board board = new Board();
            board.DrawBoard();
        }

        private static void OnExit()
        {
            Environment.Exit(0);
        }
    }
}