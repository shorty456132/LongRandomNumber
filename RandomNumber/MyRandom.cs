using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes

namespace RandomNumber
{
    public class MyRandom
    {

        /// <summary>
        /// SIMPL+ can only execute the default constructor. If you have variables that require initialization, please
        /// use an Initialize method
        /// </summary>
        public MyRandom()
        {
        }

        public int GetRand(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min,max);
        }
    }
}
