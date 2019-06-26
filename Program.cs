using System;



namespace BigOStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nemo = { "bruce", "dory", "marlin", "nigel", "squirt", "darla", "hank", "something"
                            , "gill", "nemo", "whatever", "here"};

            string[] boxes = { "a", "b", "c", "d", "e" };

            OnLinear Linear = new OnLinear();

            Linear.FindNemo(nemo);


            OnQuadratic quadratic = new OnQuadratic();

            quadratic.LogPairsOfArray(boxes);


        }
    }
}
