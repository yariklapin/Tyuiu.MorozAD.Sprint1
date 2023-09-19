// Tyuiu.MorozAD.Sprint1.Task0.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
auto sum(double x,double  y, double z)
{
    double res = (x + y + z) / 3;
    return res;
}



int main()
{
    cout << "Send first number: \n";
    int x;
    cin >> x;
    cout << "Send second number: \n";
    int y; 
    cin >> y;
    cout << "Send third number: \n";
    int z;
    cin >> z;

    cout << sum(x,y,z) <<endl;

}
