using MagicCards.ConsoleGame.GameElements;

namespace MagicCards.ConsoleGame.GameLogic
{
    public class Ai
    {
        public static void EnemyAttack(Card[] cards, Player player)
        {
            Random random = new Random();
            
            int index = random.Next(1, cards.Length);

            player.Health -= cards[index].Damage;

            Console.SetCursorPosition(34, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{cards[index].CardName}");
            Console.SetCursorPosition(38, 11);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Damage: {cards[index].Damage}   ");
            Console.ResetColor();
            Console.SetCursorPosition(61, 10);
            Console.WriteLine($"You got {cards[index].Damage} Damage.");
            Task.Delay(1500).Wait();
        }
    }
}
