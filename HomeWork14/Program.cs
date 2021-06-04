using System;

namespace HomeWork14
{
    /// <summary>
    /// Домашняя работа "бой с боссом"
    /// Легенда: Вы – теневой маг(можете быть вообще хоть кем) и у вас в арсенале есть несколько заклинаний, которые вы можете использовать против Босса. Вы должны уничтожить босса и только после этого будет вам покой.
    /// Формально: перед вами босс, у которого есть определенное кол-во жизней и определенный ответный урон.У вас есть 4 заклинания для нанесения урона боссу.Программа завершается только после смерти босса или смерти пользователя.
    /// Пример заклинаний
    /// Рашамон – призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку)
    /// Хуганзакура(Может быть выполнен только после призыва теневого духа), наносит 100 ед.урона
    /// Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп.Урон босса по вам не проходит
    /// Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения(пример - Хуганзакура). Босс должен иметь возможность убить пользователя.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int enemyHP = 250;
            int enemyDamage = 20;
            int enemyReducedDamage = 15;
            int fireBallDamage = 50;
            int fireBallSlowedDamage = 20;
            int fireballDamageDeviation = 20;
            int fireballCurrentDamage;
            int magicalArrowDamage = 10;
            int healRestorePower = 20;
            bool isEnemyRooted = false;
            bool isEnemeySlowed = false;
            Random rand = new Random();

            string userInput = "";

            while (playerHP > 0 && enemyHP > 0) 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n*********************************************************");
                Console.WriteLine("*****************FINAL BOSS LEVEL************************");
                Console.WriteLine("********************MINOTAUR*****************************");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Choos your mighty spell to cast aupon the enemy, there is no escape and one of you shell die today");
                Console.WriteLine("1: Slow but powerfull Fireball");
                Console.WriteLine("2: Tricky and unavoidable Magival Arrow with slowing side effect");
                Console.WriteLine("3: Making things easier Roots");
                Console.WriteLine("4: Refreshing and life-saving Heal");
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine($"You have {playerHP} hp and the Minotaur has {enemyHP} hp");

                userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case "1":
                        if (isEnemyRooted)
                        {
                            fireballCurrentDamage = fireBallDamage + rand.Next(-fireballDamageDeviation, fireballDamageDeviation);
                            enemyHP -= fireballCurrentDamage;
                            Console.WriteLine($"Your mighty Fireball hit directly into the foe and deals {fireballCurrentDamage} hp damage!");
                            isEnemyRooted = false;
                            isEnemeySlowed = false;
                        }
                        else if (isEnemeySlowed)
                        {
                            enemyHP -= fireBallSlowedDamage;
                            Console.WriteLine($"Your amost missed and you Fireball deals only {fireBallSlowedDamage} hp damage to the enemy!");
                            playerHP -= enemyDamage;
                            Console.WriteLine($"Mthe Minoaur crash you for {enemyDamage} hp with his fist!");
                            isEnemeySlowed = false;
                        }
                        else 
                        {
                            playerHP -= enemyDamage;
                            Console.WriteLine($"You missed and Mintoaur crash you for {enemyDamage} hp with his fist!");
                        }
                        break;
                    case "2":
                        enemyHP -= magicalArrowDamage;
                        isEnemeySlowed = true;
                        playerHP -= enemyReducedDamage;
                        Console.WriteLine($"Your Magical Arrow flies toward the enemy and deals {enemyDamage} hp damage. The minoraur appears to slower.");
                        Console.WriteLine($"Minotaur  seems to be slower but he punch you with his giant hoof, dealing {enemyReducedDamage} damage.");
                        break;
                    case "3":
                        if (isEnemeySlowed)
                        {
                            isEnemyRooted = true;
                            Console.WriteLine("Giant roots stikes from beneath and entagled Minotarus legs, preventing him movid and attacking");
                        }
                        else
                        {
                            playerHP -= enemyDamage;
                            Console.WriteLine($"Giant roots stikes from beneath and try to entagled Minotarus legs, but he was too fast anf root catches only the air.");
                            Console.WriteLine($"Minotaur hit you with his giant hoof, dealing {enemyDamage} damage.");
                        }
                        break;
                    case "4":
                        if (isEnemyRooted)
                        {
                            playerHP += healRestorePower;
                            Console.WriteLine($"You lay your hands upon yourselve and restore {healRestorePower} health points.");
                        }
                        else if (isEnemeySlowed) 
                        {
                            playerHP += healRestorePower;
                            playerHP -= enemyReducedDamage;
                            Console.WriteLine($"You lay your hands upon yourselve and restore {healRestorePower} health points.");
                            Console.WriteLine($"Minotaur is a bit dizzy but he punches you with his giant hoof, dealing {enemyReducedDamage} damage.");
                        } else 
                        {
                            playerHP += healRestorePower;
                            playerHP -= enemyDamage;
                            Console.WriteLine($"You lay your hands upon yourselve and restore {healRestorePower} health points.");
                            Console.WriteLine($"Minotaur punches you with his giant hoof, dealing {enemyReducedDamage} damage.");                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
