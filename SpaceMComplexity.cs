using System;
using System.Collections.Generic;
using System.Text;

namespace BigOStuff
{
    class SpaceMComplexity
    {
        // M.C = O(1)
        public void Boooo(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Boooo");
            }
        }



        // M.C = O(n)
        public string arrayOfHiNtimes(int n)
        {
            string[] hiArray = { };
            for (int i = 0; i < n; i++)
            {
                hiArray[i] = "hi";
            }

            return hiArray.ToString();
        }
    }
}
