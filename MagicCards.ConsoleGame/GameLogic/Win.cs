namespace MagicCards.ConsoleGame.GameLogic
{
    public class Win
    {
        public static void WinCases(Player player, Player enemy)
        {
            Console.SetCursorPosition(35, 13);

            if (enemy.Health <= 0)
            {
                Console.Write("You win!"); 
                Console.ReadKey();
            }

            if (player.Health <= 0)
            {
                Console.Write("You lose!"); 
                Console.ReadKey();
            }
        }
    }
}
