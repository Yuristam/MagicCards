using MagicCards.ConsoleGame.GameLogic;

namespace MagicCards.ConsoleGame.GameElements;

public class Board
{
    public void DrawBoard(Player player, Player enemy)
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(@$"
 ---------------------------------------------------------------------------------------------------------------------- 
|                          ----  ----  ----  ----  ----  ----                                   Your Life: {player.Health}           |
|                         |    ||    ||    ||    ||    ||    |                                  Enemy's Life: {enemy.Health}        |
|                         | <> || <> || <> || <> || <> || <> |                                                         |
|                         |    ||    ||    ||    ||    ||    |                                                         |
|                          ----  ----  ----  ----  ----  ----                                                          |
|                                                                                                                      |
|                                 ---------------------                                                                |
|                                |     Enemy Card      |                                                               |
|                                |                     |                                                               |
|                                |                     |                                                       ---- -  |
|                                 ---------------------                                                       |    ||| |
|                                                                                                             | <> ||| |
|                                 ---------------------                                                       |    ||| |
|                                |     Your Card       |                                                       ---- -  |
|                                |                     |                                                               |
|                                |                     |                                                               |
|                                 ---------------------                                                                |
|                                                                                                                      |
|                          ----  ----  ----  ----  ----  ----                                     Your Cards:          |
|                         |    ||    ||    ||    ||    ||    |                         1) {player.Cards[0].CardName} {player.Cards[0].Damage}      |
|                         | 1  || 2  || 3  || 4  || 5  || 6  |                         2) {player.Cards[1].CardName} {player.Cards[1].Damage}      |
|                         |    ||    ||    ||    ||    ||    |                         3) {player.Cards[2].CardName} {player.Cards[2].Damage}      |
|                          ----  ----  ----  ----  ----  ----                          4) {player.Cards[3].CardName} {player.Cards[3].Damage}      |
|                                                                                      5) {player.Cards[4].CardName} {player.Cards[4].Damage}      |
|                                                                                      6) {player.Cards[5].CardName} {player.Cards[5].Damage}      |
|                                                                                                                      |
 ---------------------------------------------------------------------------------------------------------------------- 
");
            if (player.Health > 0) CardHelper.ChooseCard(player.Cards, enemy);
            if (enemy.Health > 0) Ai.EnemyAttack(enemy.Cards, player);

            Win.WinCases(player, enemy);
        }
    }
}
