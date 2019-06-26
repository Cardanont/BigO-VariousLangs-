using System;
using System.Collections.Generic;
using System.Text;

namespace BigOStuff
{
    class OnQuadratic
    {

        public void LogPairsOfArray(string[] vs)
        {
            Console.WriteLine("This one is O(n^2)");
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = 0; j < vs.Length; j++)
                {
                    Console.WriteLine("{0} {1}",vs[i], vs[j]);
                }
            }
        }
    }
}
