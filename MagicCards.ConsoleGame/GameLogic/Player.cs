using MagicCards.ConsoleGame.GameElements;

namespace MagicCards.ConsoleGame.GameLogic
{
    public class Player
    {
        public Player(int health, Card[] cards)
        {
            Health = health;
            Cards = cards;
        }

        public int Health { get; set; }
        public Card[] Cards { get; set; }
    }
}
