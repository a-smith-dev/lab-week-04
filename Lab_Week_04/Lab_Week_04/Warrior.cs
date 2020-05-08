using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Week_04
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int strength, int intelligence, string weapon)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            weaponType = weapon;
        }
        public string weaponType { get; set; }
        public override void Play()
        {
            Console.WriteLine($"Warrior Name: {Name}" +
            $"\nStrength: {Strength}" +
            $"\nIntelligence: {Intelligence}" +
            $"\nWeapon Type: {weaponType}\n");
        }
    }
}
