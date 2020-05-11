using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Week_04
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public override void Play()
        {
            Console.WriteLine($"Magic Using Character Name: {Name}" +
            $"\nStrength: {Strength}" +
            $"\nIntelligence: {Intelligence}" +
            $"\nMagical Energy: {MagicalEnergy}\n");
        }
    }
}
