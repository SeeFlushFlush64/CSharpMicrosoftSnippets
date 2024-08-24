using System;

namespace RolePlayingGame
{
    class Program
    {
        static void OpeningPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Hero Vs Monster RPG");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void AttackResult(string player, int damageDealt, int updatedPlayerLife)
        {
            Console.WriteLine($"{player} was damaged and lost {damageDealt} health and now has {updatedPlayerLife}.");
        }

        static void GameWinner(string playerName)
        {
            Console.WriteLine($"{playerName} wins!");
            Console.WriteLine();
        }

        static void Gameplay()
        {
            string hero = "Hero";
            string monster = "Monster";
            int startingLife = 10;
            int minimumDamage = 1;
            int emptyLife = 0;
            int heroLife = startingLife;
            int monsterLife = startingLife;
            bool heroTurn = true;
            Random random = new Random();

            while (heroLife > emptyLife && monsterLife > emptyLife)
            {
                int damageDealt = random.Next(minimumDamage, startingLife); // Ensure damage is at least 1

                if (heroTurn)
                {
                    heroLife -= damageDealt;
                    AttackResult(hero, damageDealt, heroLife);
                    if (heroLife <= emptyLife)
                    {
                        GameWinner(monster);
                        break; // Exit loop once the game is won
                    }
                }
                else
                {
                    monsterLife -= damageDealt;
                    AttackResult(monster, damageDealt, monsterLife);
                    if (monsterLife <= emptyLife)
                    {
                        GameWinner(hero);
                        break; // Exit loop once the game is won
                    }
                }

                heroTurn = !heroTurn; // Switch turns
            }
        }

        static void Main(string[] args)
        {
            OpeningPrompt();
            Gameplay();
        }
    }
}
