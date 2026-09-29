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
        static int XPAmountToLevel = 100;
        static int currentXP;
        static int currentLevel = 1;
        static bool isDead = false;
        static ConsoleColor OriginalColor;
        static ConsoleColor TextColor = ConsoleColor.DarkMagenta;
        static ConsoleColor HUDColor = ConsoleColor.DarkGreen;
        static ConsoleColor xpColor = ConsoleColor.DarkBlue;
        static ConsoleColor Damagecolor = ConsoleColor.DarkRed;
        static void Main(string[] args)
        {
            Console.ForegroundColor = TextColor;
            currentHealth = MaxHealth;
            ShowHUD();
            AddXP(50);
            ShowHUD();
            AddXP(60);
            ShowHUD();
            AddXP(120);
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            AddXP(180);
            ShowHUD();
            AddXP(250);
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = OriginalColor;
        }
        static void ShowHUD()
        {        
            if (currentHealth <= 0)
            {
               isDead = true;
            }
            if (currentHealth > MaxHealth)
            {
                currentHealth = MaxHealth;
            }
            Console.ForegroundColor = HUDColor;
            Console.WriteLine("======================");
            Console.WriteLine("Health - " + currentHealth);
            Console.WriteLine("XP - " + currentXP);
            Console.WriteLine("Xp Required - " + XPAmountToLevel);
            Console.WriteLine("Level - " + currentLevel);
            Console.WriteLine("======================");
            Console.ForegroundColor = TextColor;
        }
        static void AddXP(int xpAdded)
        {
            Console.ForegroundColor = xpColor;
            currentXP += xpAdded;
            int spillXP = xpAdded - currentXP;
            Console.WriteLine("%%%%%%%%%%%%%%%%");
            Console.WriteLine("You earned XP! - " + xpAdded);
            Console.WriteLine("%%%%%%%%%%%%%%%%");
            if (currentXP >= XPAmountToLevel)
            {
                currentXP = currentXP - XPAmountToLevel;
                XPAmountToLevel += 100;
                currentLevel += 1;
                currentHealth += 25;
                MaxHealth += 25;
                Console.WriteLine("*****************");
                Console.WriteLine("You Leveled Up!");
                Console.WriteLine("*****************");
                Console.ForegroundColor = TextColor;
            }
        }
        static void TakeDamage(int damage)
        {
            Console.ForegroundColor = Damagecolor;
            int spillDamage = damage;

                currentHealth -= damage;
                if (currentHealth <= 0)
                {
                    currentHealth = 0;
                }            
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Player Took Damage! - " + damage);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = TextColor;
        }
    }
}
