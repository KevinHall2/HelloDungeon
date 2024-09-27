using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dungeon
{
    //this is all a brief and incomplete reimagining to try and incorporate structs
    internal class ReplicaGame
    {
        struct Player
        {
            //main stats
            public string name;
            public int strength;
            public int body;
            public int mind;
            public int maxHealth;
            public int currentHealth;

            public Player(
                //main stats
                string name,
                int strength,
                int body,
                int mind,
                int maxHealth,
                int currentHealth)
            {
                this.name = name;
                this.strength = strength;
                this.body = body;
                this.mind = mind;
                this.maxHealth = maxHealth;
                this.currentHealth = currentHealth;

            }
        }
        struct Monster
        {
            public string name;
            public int damage;
            public int defense;
            public int maxHealth;
            public int currentHealth;

            public Monster (
                string name,
                int damage,
                int defense,
                int maxHealth,
                int currentHealth)
            {
                this.name = name;
                this.damage = damage;
                this.defense = defense;
                this.maxHealth = maxHealth;
                this.currentHealth = currentHealth;
            }
        }
        internal class Game
        {
            int currentArea = 1;

            bool _gameOver = false;

            Monster _monster1;

            Monster _monster2;

            Monster _monster3;

            Monster _monster4;

            Player player1;

            void Start()
            {
                _monster1 = new Monster("Hydra", 12, 12, 12, 12);

                _monster2 = new Monster("Naga", 12, 12, 12, 12);

                _monster3 = new Monster("The Celestial", 19, 19, 19, 19);

                _monster4 = new Monster("The Fiend", 19, 19, 19, 19);

                player1 = new Player("", 1, 1, 1, 1, 1);

                //introduction
                GetStoryText("You stir in your sleep as you dream, and in this dream a robed figure with contemplative red eyes manifests before you, becoming the only presence in a black void. " +
                    "The figure poses a simple question, but it doesn't conventionally speak it, and instead imprints it into your mind.");
                GetPlayerNameInput("'What is your name?' You feel incredibly compelled to answer the strange demand.");
                GetStoryText("After your response, the figure seems to project more words into your mind. 'Well. Greetings " + player1.name + ". " +
                    "This... meeting of ours will only last for the duration of your dream. I simply want to play a game in the form of a small adventure for my boredom'. " +
                    "The figure then looks you up and down, and its eyes seem to narrow in dissapointment. 'You are rather... ordinary for the game. Determine a specialization to remedy this.'");
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
            //character name input function
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
                    player1.name = input;
                    inputRecieved = 1;
                }
                return inputRecieved;

            }
        }
    }
}
