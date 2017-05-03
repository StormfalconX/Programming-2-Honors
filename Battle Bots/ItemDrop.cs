using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle_Bots
{
    class ItemDrop
    {
        public static Random rNum = new Random();
        public static int randNum = rNum.Next(1, 6);
        public static int randNum2 = rNum.Next(1, 4);

        public static int Generate()
        {
            randNum = rNum.Next(1, 51);
            randNum2 = rNum.Next(1, 4);

            if (randNum <= 10)
            {
                if (randNum2 == 1)
                {
                    return 1; //AirStrike
                }
                else if (randNum2 == 2)
                {
                    return 2; //OrbitalLaser
                }
                else
                {
                    return 3; //Nuke
                }
            }

            return 0; //Nothing
        }


    }
}
