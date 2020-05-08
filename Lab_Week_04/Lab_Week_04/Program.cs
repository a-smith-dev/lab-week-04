using System;
using System.Collections.Generic;

namespace Lab_Week_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab for week 4
            // Bonus 13 in the book

            var gameCharacters = new List<GameCharacter>();
            var warrior1 = new Warrior("Leeroy Jenkins", 21, 3, "Holy Greatsword");
            var warrior2 = new Warrior("Leeroy Jenkins, Jr.", 13, 8, "Holy Shortsword");
            gameCharacters.Add(warrior1);
            gameCharacters.Add(warrior2);
            var wizard1 = new Wizard("Merlin", 10, 19, 12, 20);
            var wizard2 = new Wizard("Gandalf", 13, 24, 30, 5);
            var wizard3 = new Wizard("Sarumon", 13, 21, 28, 7);
            gameCharacters.Add(wizard1);
            gameCharacters.Add(wizard2);
            gameCharacters.Add(wizard3);
            foreach (var character in gameCharacters)
            {
                character.Play();
            }
        }
    }
}
