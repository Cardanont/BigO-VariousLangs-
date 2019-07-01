#include <iostream>
#include <string>

using namespace std;

void FindNemo(string array[])
{
    for (size_t i = 0; i < sizeof(array); i++)
    {
        if (array[i] == "nemo")
            cout << "Found Nemo!"; 
    }
}

int main()
{
    string nemo[] = {"bruce", "dory", "marlin", "nigel", "squirt", "darla", "hank", "something", "gill", "nemo", "whatever"};

    FindNemo(nemo);

    cout << "End of the test";

    return 0;
}