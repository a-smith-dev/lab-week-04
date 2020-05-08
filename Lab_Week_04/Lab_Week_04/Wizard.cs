using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Week_04
{
    class Wizard : MagicUsingCharacter
    {
        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            MagicalEnergy = magicalEnergy;
            SpellNumber = spellNumber;
        }
        public int SpellNumber { get; set; }
        public override void Play()
        {
            Console.WriteLine($"Wizard Name: {Name}" +
            $"\nStrength: {Strength}" +
            $"\nIntelligence: {Intelligence}" +
            $"\nMagical Energy: {MagicalEnergy}" +
            $"\nSpell Number: {SpellNumber}\n");
        }
    }
}
