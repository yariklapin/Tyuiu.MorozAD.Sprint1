#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
    int a;
    int b;
    int c;
    int d;

    cout << "Введите 3-х знчное число: \n";
    int x;
    cin >> x;
    if (x >= 100 && x <= 999)
    {
        b = (x / 10) % 10;
        c = x % 10;
        a = x / 100;
        d = (b * a *c);

    }
    else
        cout << "Я сказал 3-x значное!!!! \n";

    cout << "Введите любое число: \n";
    int A;
    cin >> A;

    if (d > A)
    {
        cout << "Это число больше!! " <<" " << d << " > " << A;
    }
    else
        cout << "Это число меньше!!" <<" "<< d << " < " << A;


}
