namespace MagicCards.ConsoleGame.GameElements
{
    public class Board
    {
        public static int PlayerCardsQuantity = 6;
        public static int PlayerLife = 6;
        public static int EnemyCardsQuantity = 6;
        public static int EnemyLife = 6;

        public void DrawBoard()
        {
            while (PlayerLife > 0 || EnemyLife > 0)
            {
                Console.Clear();
                Console.WriteLine(@$"
 --------------------------------------------------------------------------------------
|                          ----  ----  ----  ----  ----  ----                          |
|                         |    ||    ||    ||    ||    ||    |                         |
|                         | <> || <> || <> || <> || <> || <> |                         |
|                         |    ||    ||    ||    ||    ||    |                         |
|                          ----  ----  ----  ----  ----  ----                          |
|                                                                                      |
|                                 ---------------------                                |
|                                |                     |                               |
|                                |     Enemy Card      |                               |
|                                |                     |                       ---- -  |
|                                 ---------------------                       |    ||| |
|                                                                             | <> ||| |
|                                 ---------------------                       |    ||| |
|                                |                     |                       ---- -  |
|                                |     Your Card       |                               |
|                                |                     |                               |
|                                 ---------------------                                |
|                                                                                      |
|                          ----  ----  ----  ----  ----  ----                          |
|                         |    ||    ||    ||    ||    ||    |                         |
|                         | 1  || 2  || 3  || 4  || 5  || 6  |                         |
|                         |    ||    ||    ||    ||    ||    |                         |
|                          ----  ----  ----  ----  ----  ----                          |
 --------------------------------------------------------------------------------------
");

                Console.ReadKey();
            }
        }
    }
}
