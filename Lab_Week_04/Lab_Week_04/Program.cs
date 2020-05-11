using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_Week_04
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome! Below is the starting party for this adventure:\n");
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
                Console.Write("Would you like to change this party? (y/n) ");
                while (ValidateYesNo(Console.ReadLine()) == "y")
                {
                    Console.Write("Which character? (enter 1-5. Or enter 0 to cancel) ");
                    var number = ValidatePlayerChoice(Console.ReadLine());
                    if (number == 0)
                        break;
                    else if (number < 3)
                        gameCharacters[--number] = GenerateWarrior();
                    else
                        gameCharacters[--number] = GenerateWizard();
                    Console.Write("Would you like to change another? (y/n) ");
                }
                Console.WriteLine("\nFinalized party: ");
                foreach (var character in gameCharacters)
                    character.Play();
                Console.Write("Would you like to start again? (y/n) ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
            Console.WriteLine("\nThank you for playing!");
        }

        static string ValidateYesNo(string input)
        {
            input = input.ToLower();
            while (!Regex.IsMatch(input, "^[yn]$"))
            {
                Console.Write("Please enter y or n: ");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }

        static int ValidatePlayerChoice(string input)
        {
            while (true)
            {
                var number = ValidateNonNegativeNumber(input);
                if (number > 5)
                {
                    Console.Write("Please enter a number between 0 and 5 (inclusive): ");
                    input = Console.ReadLine();
                }
                else
                    return number;
            }
        }

        static int ValidateNonNegativeNumber(string input)
        {
            var number = -1;
            while (!int.TryParse(input, out number) || number < 0)
            {
                Console.Write("Please enter a non-negative integer: ");
                input = Console.ReadLine();
            }
            return number;
        }

        static Warrior GenerateWarrior()
        {
            var message = "Please enter the character's";
            return new Warrior(ChooseName(message), ChooseStrength(message), ChooseIntelligence(message), ChooseWeapon(message));
        }

        static Wizard GenerateWizard()
        {
            var message = "Please enter the character's";
            return new Wizard(ChooseName(message), ChooseStrength(message), ChooseIntelligence(message), ChooseMagicalEnergy(message), ChooseSpellNumber(message));
        }

        static string ChooseName(string message)
        {
            Console.Write($"{message} name: ");
            return Console.ReadLine();
        }

        static int ChooseStrength(string message)
        {
            Console.Write($"{message} strength: ");
            return ValidateNonNegativeNumber(Console.ReadLine());
        }

        static int ChooseIntelligence(string message)
        {
            Console.Write($"{message} intelligence: ");
            return ValidateNonNegativeNumber(Console.ReadLine());
        }

        static string ChooseWeapon(string message)
        {
            Console.Write($"{message} weapon type: ");
            return Console.ReadLine();
        }

        static int ChooseMagicalEnergy(string message)
        {
            Console.Write($"{message} magical energy: ");
            return ValidateNonNegativeNumber(Console.ReadLine());
        }

        static int ChooseSpellNumber(string message)
        {
            Console.Write($"{message} number of spells: ");
            return ValidateNonNegativeNumber(Console.ReadLine());
        }
    }
}