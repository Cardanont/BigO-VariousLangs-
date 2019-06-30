#include <iostream>
#include <string>
#include <bits10_1.h>

using namespace std;

void FindNemo(string array[])
{
    for (size_t i = 0; i < sizeof(array); i++)
    {
        if (array[i] == "nemo")
            std::cout << "Found Nemo!"; 
    }
}

int main()
{
    string nemo[] = {"bruce", "dory", "marlin", "nigel", "squirt", "darla", "hank", "something", "gill", "nemo", "whatever"};

    FindNemo(nemo);
    std::cin.clear();
    std::cin.ignore();

    return 0;
}