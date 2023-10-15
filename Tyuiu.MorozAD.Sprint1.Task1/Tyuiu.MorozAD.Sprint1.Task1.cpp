// Tyuiu.MorozAD.Sprint1.Task1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
    int a;
    int b;
    int c;
    int d;

    cout <<"Send number: \n";
    int x;
    cin >> x;
    if (x >= 100 && x <= 999)
    {
         b = (x / 10)%10;
         c = x % 10;
         a = x / 100;
         d = (b + a + c);

    }
    else
        cout << "it's not number with 3 digits \n";

    if (d>=10 && d<= 100) 
    {
        cout << "Summ: " << d;
    }
    else
        cout << "ne dvuxznacnoe";
    

}

