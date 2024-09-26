namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles
            string heroFirstName = "Jayson";
            string heroLastName = "Packer";
            string heroFullName;
            string villianTitle = "Sire of fire";
            string minionTitle =  "flambo";
            string villianName;
            string minion1Name;
            string minion2Name;
            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;
            // Bein intstruction

            heroFullName = heroFirstName + " " + heroLastName;
            Console.WriteLine("Behold the legendary hero of programmng, whose name is : "+ heroFullName);
            villianName = "Louise";
            minion1Name = "Tina";
            minion2Name = "Gene";
            Console.WriteLine(heroFullName + "'s arch rival is " + villianName + " the " + villianTitle);
            // the minions
            Console.WriteLine(villianName + " the " + villianTitle + " is always surrouded by " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
            // the fight begins
            Console.WriteLine("The figheter enter the room!");
            Console.WriteLine("Hero's Health " + heroHealth);
            Console.WriteLine("Boss's Health " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);
            // Bad guys strike first 
            // starting with the boss
            Console.WriteLine(villianName+ " the " + villianTitle + " attacks " +  heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Minions attack
            Console.WriteLine("The evil flambos attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero fights back
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            // Heroes damage
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //The minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round of fight
            Console.WriteLine("The hero and boss continue to fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the cuurent health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
            //do math
            bossHealth = bossHealth - heroStrength;
            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");

            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");

        }
    }
}
