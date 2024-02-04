using MagicCards.ConsoleGame.GameLogic;

namespace MagicCards.ConsoleGame.GameElements
{
    public static class CardHelper
    {
        public static void ChooseCard(Card[] cards, Player enemy)
        {
            int index = 0;

            ShowPlayerCards(cards, index);

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (index + 1 < cards.Length)
                    {
                        index++;
                    }
                    
                    ShowPlayerCards(cards, index);
                }

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                    }

                    ShowPlayerCards(cards, index);
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    cards[index].PlayerAttack(cards[index], enemy);
                    break;
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        private static void ShowPlayerCards(Card[] cards, int index = 0)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Card card = cards[i];

                if (i == index)
                {
                    Console.SetCursorPosition(34, 16);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{card.CardName}");
                    Console.SetCursorPosition(38, 17);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Damage: {card.Damage}   ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("");
                }

            }
        }
    }
}
