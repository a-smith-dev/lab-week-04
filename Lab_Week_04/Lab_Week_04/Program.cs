using System;
using System.Collections.Generic;

namespace Lab_Week_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacters = new List<GameCharacter>
            {
                new Warrior("Leeroy Jenkins", 21, 3, "Holy Greatsword"),
                new Warrior("Leeroy Jenkins, Jr.", 13, 8, "Holy Shortsword"),
                new Wizard("Merlin", 10, 19, 12, 20),
                new Wizard("Gandalf", 13, 24, 30, 5),
                new Wizard("Sarumon", 13, 21, 28, 7)
            };
            foreach (var character in gameCharacters)
                character.Play();
        }
    }
}