using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.M.C_s_Shield_Health_Spillover
{
    internal class Program
    {
        static int MaxHealth = 100;
        static int currentHealth;
        static int maxXPRequired = 100;
        static int currentXP;
        static int currentLevel = 1;

        static void Main(string[] args)
        {
            currentHealth = MaxHealth;
            ShowHUD();
            AddXP(50);
            ShowHUD();
            AddXP(60);
            ShowHUD();
            AddXP(120);
            ShowHUD();
            TakeDamage(40);
            ShowHUD();
            AddXP(180);
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
        }
        static void ShowHUD()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Health - " + currentHealth);
            Console.WriteLine("XP - " + currentXP);
            Console.WriteLine("Xp Required - " + maxXPRequired);
            Console.WriteLine("Level - " + currentLevel);
            Console.WriteLine("======================");
        }
        static void AddXP(int xpAdded)
        {
            currentXP += xpAdded;
            int spillXP = xpAdded - currentXP;
            Console.WriteLine("%%%%%%%%%%%%%%%%");
            Console.WriteLine("You earned XP! - " + xpAdded);
            Console.WriteLine("%%%%%%%%%%%%%%%%");
            if (currentXP >= maxXPRequired)
            {
                currentXP = currentXP - maxXPRequired;
                maxXPRequired += 100;
                currentLevel += 1;
                currentHealth += 25;
                MaxHealth += 25;
                Console.WriteLine("*****************");
                Console.WriteLine("You Leveled Up!");
                Console.WriteLine("*****************");
            }
        }
        static void TakeDamage(int damage)
        {
            int spillDamage = damage;

                currentHealth -= damage;
                if (currentHealth <= 0)
                {
                    currentHealth = 0;
                }            
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Player Took Damage! - " + damage);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");

        }
    }
}
