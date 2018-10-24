using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class MagicUsingCharacter : GameCharacter
    {

        public MagicUsingCharacter()
        {

        }

        public int MagicalEnergy { get; set; }


        public override void Play()
        {
            Console.WriteLine("Character name: {0}\nCharacter Strength: {1}" +
                              "\nCharacter Intelligence: {2}\nMagical Energy: {3}", Name, Strength, Intelligence, MagicalEnergy);

        }

    }
}
