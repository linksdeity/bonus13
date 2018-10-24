using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class Warrior : GameCharacter
    {
        public Warrior() : base()
        {

        }


        public string WeaponType { get; set; }


        public override void Play()
        {
            Console.WriteLine("Character name: {0}\nCharacter Strength: {1}" +
                              "\nCharacter Intelligence: {2}\nWeapon Type: {3}", Name, Strength, Intelligence, WeaponType);

        }
    }
}
