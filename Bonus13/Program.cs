using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5];

            gameCharacters[0] = new Warrior{ Name = "Brian", Intelligence = 8, Strength = 18, WeaponType = "Axe"};
            gameCharacters[1] = new Warrior { Name = "Charlse", Intelligence = 7, Strength = 19, WeaponType = "Sword" };
            gameCharacters[2] = new Wizard { Name = "Moon Unit", Intelligence = 19, Strength = 7, MagicalEnergy = 10, SpellNumber = 5 };
            gameCharacters[3] = new Wizard { Name = "Dweezil", Intelligence = 17, Strength = 12, MagicalEnergy = 8, SpellNumber = 4 };
            gameCharacters[4] = new Wizard { Name = "The Gerber Baby", Intelligence = 21, Strength = 17, MagicalEnergy = 100, SpellNumber = 45 };

            foreach(GameCharacter character in gameCharacters)
            {
                character.Play();
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();

        }
    }
}
