using MagicCards.ConsoleGame.GameElements;
using MagicCards.ConsoleGame.GameLogic;

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
            Card card1 = new Card("        Fire         ",1);
            Card card2 = new Card("        Water        ",1);
            Card card3 = new Card("        Earth        ",3);
            Card card4 = new Card("        Light        ",2);
            Card card5 = new Card("        Sword        ",1);
            Card card6 = new Card("        Air          ",4);
            Card[] cards = { card1, card2, card3, card4, card5, card6 };
            Player player = new Player(5, cards);
            Player enemy = new Player(5, cards);
            board.DrawBoard(player, enemy);
        }

        private static void OnExit()
        {
            Environment.Exit(0);
        }
    }
}