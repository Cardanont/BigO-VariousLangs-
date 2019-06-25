using System;



namespace BigOStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nemo = { "bruce", "dory", "marlin", "nigel", "squirt", "darla", "hank", "something"
                            , "gill", "nemo", "whatever", "here"};

            OnLinear Linear = new OnLinear();

            Linear.FindNemo(nemo);
        }
    }
}
