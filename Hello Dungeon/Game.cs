using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dungeon
{
    internal class Game
    {
        public void Run()
        {
            string playerName = "Voblius";
            //main stats
            int playerStrength = 2;
            int playerBody = 2;
            int playerMind = 2;
            //inventory
            int playerWealth = 3;
            int playerWeaponValue = 2;
            int playerArmorRating = 2;
            int playerFocusDensity = 2;
            //totals
            int playerDamageOutput = (playerStrength + playerWeaponValue);
            int playerDefenseCapability = (playerArmorRating + playerBody);
            int playerAether = (playerMind + playerFocusDensity);
            float playerHealth = (playerBody + 10);
            //conditions
            bool isScarWarm = false;

            Console.WriteLine("Hello " + playerName);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon...");
            Console.WriteLine();
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Aether: " + playerAether);
            Console.WriteLine("Wealth: " + playerWealth);
            Console.WriteLine(
                "As you begin traversing the dungeon, you come into a hallway that branches into two different directions." +
                "A left door and a right door are before you. Which do you choose?"
                );
        }
    }
}
