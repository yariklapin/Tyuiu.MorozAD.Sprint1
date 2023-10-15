// Tyuiu.MorozAD.Sprint1.Task3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");
    cout << "Введите число\n";
    int x;
    int d;
    cin >> x;
    if (x % 2 == 0)
        if (x != 1000 && x % 4 == 0)
            d = x * 2;
        else
            d = x / 5;
    else
        cout << "Не проходит условие)" << endl;
    cout << "Ответ: " << d << endl;
}

