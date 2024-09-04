using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dungeon
{
    internal class Game
    {
        struct Player
        {
            //main stats
            public string playerName;
            public int playerStrength;
            public int playerBody;
            public int playerMind;
            public int playerMaxHealth;
            public int playerCurrentHealth;

            public Player(
                //main stats
                string name,
                int strength, 
                int body, 
                int mind, 
                int maxHealth, 
                int currentHealth ) 
            {
                name = playerName;
                strength = playerStrength;
                body = playerBody;
                mind = playerMind;
                maxHealth = playerMaxHealth;
                currentHealth = playerCurrentHealth;

            }
        }
        public void Run()
        {
            Player mainCharacter = new Player( 
                name: "",
                strength: 1,
                body: 1,
                mind: 1,
                maxHealth: 0,
                currentHealth: 0 );

            //introduction
            GetStoryText("You stir in your sleep as you dream, and in this dream a robed figure with contemplative red eyes manifests before you. " +
                "The figure poses a simple question, but it doesn't conventionally speak it, and instead imprints it into your mind.");
            GetPlayerNameInput("'What is your name?' You feel incredibly compelled to answer the strange demand.");
            GetStoryText("After your response, the figure seems to project more words into your mind. 'Well. Greetings " + mainCharacter.playerName + ". " +
                "This... meeting of ours will only last for the duration of your dream. I simply want to play a game in the form of a small adventure for my boredom'. " +
                "The figure then looks you up and down, and its eyes seem to narrow in dissapointment. 'You are rather... ordinary for the game. Determine a specialization to remedy this.'");
            //class selection
            GetClassSelectionInput("Three such 'specializations' forcibly inject themselves into your head: A Warrior, with a balance between physical offense and defense." +
                " A Scoundrel, with a focus on physical offense. A Mystic, with a focus on magical arts.", "warrior", "scoundrel", "mystic");
            //statsitic display
            GetStoryText("As you adjust to your new power, you see the figure regard you with what seems like acceptance." +
                "'Good. To help give you an idea of what you can do now in this game, I'll rate your abilities from a scale of 1-20.'");
            string playerStatistics = GetPlayerStatistics();
            Console.WriteLine();
            Console.WriteLine("As you begin traversing the dungeon, you come into a hallway that branches into two different directions.");
            Console.WriteLine(" A left door and a right door are before you.");
            string decisionBranchedHallway = "";
            while (decisionBranchedHallway != "left" && decisionBranchedHallway != "right")

            {
                Console.WriteLine("Which do you choose?");
                decisionBranchedHallway = Console.ReadLine();
                if (decisionBranchedHallway == "left")
                {
                    Console.WriteLine("You trend towards the left door and push against its heavy stone frame to open it." +
                        " As you get the door a fraction of the way open, a deluge of freshwater pours out, forcing the door" +
                        "the rest of the way open and sweeping you into a subterranean lake.");
                }
                else if (decisionBranchedHallway == "right")
                {
                    Console.WriteLine("You move towards the right door and find that you have to lift it from the bottom to open it.");
                }
                else
                {
                    Console.WriteLine("You are unable to do that.");
                }
            }
            //class selection function
            int GetClassSelectionInput(string description, string option1, string option2, string option3)
            {
                string input = "";
                int inputRecieved = 0;
                while (inputRecieved != 1 && inputRecieved != 2 && inputRecieved != 3)
                {
                    Console.WriteLine(description);
                    Console.WriteLine("1. " + option1);
                    Console.WriteLine("2. " + option2);
                    Console.WriteLine("3. " + option3);
                    Console.Write("> ");

                    input = Console.ReadLine();

                    if (input == "1" || input == option1)
                    {
                        inputRecieved = 1;
                        Console.WriteLine("You focus on the Warrior, and feel yourself become a paragon of athleticism.");
                        Console.WriteLine("A broadsword manifests itself from red energy in your dominant hand, and protective armor dons your body.");
                        //class statistic benefits
                        mainCharacter.playerStrength += 6;
                        mainCharacter.playerBody += 7;
                        mainCharacter.playerMind += 2;
                        mainCharacter.playerMaxHealth += 15;
                        mainCharacter.playerCurrentHealth += 15;
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                    else if (input == "2" || input == option2)
                    {
                        inputRecieved = 2;
                        Console.WriteLine("You focus on the Scoundrel, and feel yourself embody the mentality of a savage opportunist.");
                        Console.WriteLine("A wicked dagger manifests itself from red energy in your dominant hand, and you feel your senses sharpen.");
                        //class statistic benefits
                        mainCharacter.playerStrength += 15;
                        mainCharacter.playerBody += 4;
                        mainCharacter.playerMind += 4;
                        mainCharacter.playerMaxHealth += 10;
                        mainCharacter.playerCurrentHealth += 10;
                        Console.WriteLine("<<Press any key to continue.>>");
                        Console.ReadKey();
                    }
                    else if (input == "3" || input == option3)
                    {
                        inputRecieved = 3;
                        Console.WriteLine("You focus on the Mystic, and feel the ether of reality bend more easily to your will.");
                        Console.WriteLine("A sphere of red reality-ether coalesces into your dominant hand. You can use this to focus your magics.");
                        //class statistic benefits
                        mainCharacter.playerStrength += 2;
                        mainCharacter.playerBody += 2;
                        mainCharacter.playerMind += 15;
                        mainCharacter.playerMaxHealth += 7;
                        mainCharacter.playerCurrentHealth += 7;
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You attempt to manifest that idea, but the figure purges it from your mind.");
                        Console.WriteLine("'Pick one of the three: Warrior, scoundrel, or mystic.'");
                        Console.Write("> ");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                return inputRecieved;
            }
            //description or story text function
            string GetStoryText(string storyText)
            {
                Console.Clear();
                Console.WriteLine(storyText);
                Console.WriteLine("<<Press any key to continue.>>");
                Console.ReadKey();
                return storyText;
            }
            //input function
            int GetPlayerNameInput(string premiseDescription)
            {
                string input = "";
                int inputRecieved = 0;
                while (inputRecieved != 1)
                {
                    Console.Clear();
                    Console.WriteLine(premiseDescription);
                    Console.Write(">");
                    input = Console.ReadLine();
                    mainCharacter.playerName = input;
                    inputRecieved = 1;
                }
                return inputRecieved;
                
            }
            //stat display function
            string GetPlayerStatistics()
            {
                string statisticsResult =
                        ("'Your physical offense is " + mainCharacter.playerStrength + ".") +
                        (" Your defensive capability is " + mainCharacter.playerBody + ".") +
                        (" Your magical capability is " + mainCharacter.playerMind + ".") +
                        (" Your 'maximum hit points' are " + mainCharacter.playerMaxHealth + ".") +
                        (" Your 'current hit points' are " + mainCharacter.playerCurrentHealth + ".'");
                    
                Console.WriteLine(statisticsResult);
                Console.WriteLine("<<Press any key to continue.>>");
                Console.ReadKey();
                return statisticsResult;
            }
        }
    }
}
