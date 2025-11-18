// --- Day 1: Simple Helloworld ---
using System;

namespace AssasinGuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, Hunters! Welcome to the Assassin's Guild");
            Console.WriteLine($"{97 + 3}% Trust");

            // Day 2: Variables & Data Types
            int amount = 210000, age = 34;
            string name = "Jenna";
            bool targetAlive = true;
            char dollarSign = '$';

            Console.WriteLine("Target is: " + name);
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Dead or Alive: " + targetAlive);
            Console.WriteLine("Reward is: " + amount + dollarSign);

            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Enter Age");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age is: " + userAge);

            int ageRequired = 26;
            if (userAge >= ageRequired)
            {
                Console.WriteLine("You Have the Job");
            }
            else
            {
                Console.WriteLine("You are not eligible for the job. You should be at least 26");
            }

            int dayRemaining = 10;
            dayRemaining--;
            Console.WriteLine(dayRemaining + " Days since bounty was posted");

            Console.WriteLine("Enter Days Remaining in real Time");
            int dayRemainingNow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days Remaining is: " + dayRemainingNow);

            if (dayRemainingNow == 0)
            {
                Console.WriteLine("Mission Expired");
            }
            else if (dayRemainingNow < 2)
            {
                Console.WriteLine("Time is critical");
            }
            else
            {
                Console.WriteLine("Mission still available");
            }

            // Day 3: Math section
            string[] weapons = { "Desert Eagle", "AX50 Sniper", "Tanto Knife" };
            weapons[0] = "Glock 19";
            Console.WriteLine(weapons.Length + " Weapons Available");

            Array.Sort(weapons);
            foreach (string weapon in weapons)
            {
                Console.WriteLine(weapon);
            }

            int bonus = 50000;
            int penalty = 60000;
            int total = amount + bonus;
            int penaltyTotal = amount - penalty;

            Console.WriteLine("Early reward is: " + total + dollarSign);
            Console.WriteLine("Casualty Penalty: " + penaltyTotal + dollarSign);

            // Conditionals and Loops
            int shootAttempts = 0;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Attempt number: " + i);
            }

            while (targetAlive)
            {
                Console.WriteLine("First contact....");
                shootAttempts++;

                if (shootAttempts >= 3)
                {
                    targetAlive = false;
                    Console.WriteLine("Target neutralized. Collect reward");
                }
                else
                {
                    Console.WriteLine("Target still moving... Do not falter");
                }
            }

            // Day 4: Multidimensional Arrays
            int[,] hunterKills = { { 1, 2, 3 }, { 4, 5, 6 } };

            if (userAge >= ageRequired)
            {
                Console.WriteLine(userName + " kills in Mission 2 is: " + hunterKills[0, 1]);
            }
            else
            {
                Console.WriteLine("Too young for this life, boy");
            }

            foreach (int kill in hunterKills)
            {
                Console.WriteLine("Total kills: " + kill);
            }

            // Final Reward
            int finalAmount = amount + bonus - penalty;
            Console.WriteLine("Your Final reward is: " + finalAmount + dollarSign);

            // Call method
            MyMethod(userName);
        }

        // Method defined outside Main
        static void MyMethod(string userName)
        {
            Console.WriteLine("Have a nice day " + userName + ". Leave your review for more jobs.");
        }
    }
}