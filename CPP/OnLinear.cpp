#include <iostream>
#include <string>

using namespace std;




int main()
{
    string nemo[] = {"bruce", "dory", "marlin", "nigel", "squirt", "darla", "hank", "something", "gill", "nemo", "whatever"};

    for (size_t i = 0; i < sizeof(nemo); i++)
    {
        if (nemo[i] == "nemo")
            cout << "Found Nemo!";
    }

    return 0;
}