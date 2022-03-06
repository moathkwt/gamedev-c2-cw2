using System;

namespace c2_cw1
{
    class Program
    {
        static void Main(string[] args)

        {
            string characterName = "clash";

            double characterHeight = 1.74;

            double characterspeed = 1.50;

            int characterage = 17;

            string superpower1 = "breakwood";

            string superpower2 = "breakwalls";

            string heroname = "arrow";

            int heroage = 18;

            double heroHeight = 1.72;

            string herosuperPower1 = "breakbuilding";

            string herosuperPower2 = "speakfast";


            bool heightCheck = (heroHeight < characterHeight);

            int ageDifference = (heroage-characterage);

            Console.WriteLine(" my name is " + characterName + " my age is " + characterage + " my superpower is " + superpower1 + " my second superpower is "+ superpower2  + " and my speed is " + characterspeed );
            Console.WriteLine(" the height check " + heightCheck + " and the agedifference " + ageDifference);
        }
    }

}
