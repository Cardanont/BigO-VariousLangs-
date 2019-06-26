using System;
using System.Collections.Generic;
using System.Text;

namespace BigOStuff
{
    class OnLinear
    {
        
        public void FindNemo(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "nemo")
                    Console.WriteLine("This is a program that Time compexity is O(n)and Found Nemo of course \n\n");
            }
        }
    }
}
