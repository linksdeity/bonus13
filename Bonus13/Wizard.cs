using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class Wizard : MagicUsingCharacter
    {

        public Wizard()
        {

        }

        public int SpellNumber { get; set; }


        public override void Play()
        {
            Console.WriteLine("Character name: {0}\nCharacter Strength: {1}" +
                              "\nCharacter Intelligence: {2}\nMagical Energy: {3}\nSpell Number: {4}", Name, Strength, Intelligence, MagicalEnergy, SpellNumber);

        }
    }
}
