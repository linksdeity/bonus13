using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class GameCharacter
    {

        public GameCharacter()
        {

        }

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public virtual void Play()
        {
            Console.WriteLine("Character name: {0}\nCharacter Strength: {1}" +
                              "\nCharacter Intelligence: {2}", Name, Strength, Intelligence);

        }




    }
}
