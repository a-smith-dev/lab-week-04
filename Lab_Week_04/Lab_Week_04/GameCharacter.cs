using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Week_04
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nStrength: {Strength}" +
                $"\nIntelligence: {Intelligence}\n");
        }
    }
}
