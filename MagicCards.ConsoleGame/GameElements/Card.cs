using MagicCards.ConsoleGame.GameLogic;

namespace MagicCards.ConsoleGame.GameElements;

public class Card
{
    public Card(string cardName, int damage)
    {
        CardName = cardName;
        Damage = damage;
    }

    public string CardName { get; set; }
    public int Damage { get; set; }

    public void PlayerAttack(Card card, Player enemy)
    {
        enemy.Health -= card.Damage;
        
        Console.SetCursorPosition(61, 16);
        Console.WriteLine($"Enemy got {card.Damage} damage.");
    }
}
