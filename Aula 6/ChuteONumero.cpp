#include <iostream>
#include <random>
using namespace std;

int main()
{
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int num = distribuicao(numAleatorio);
    int chute;

    do {
        cout << "Chute um numero de 1 a 100" << endl;
        cin >> chute;
        
        if (chute > num){
            cout << "Chute Alto" << endl;
        }
        if (chute < num){
            cout << "Chute Baixo" << endl;
        }
    }while(num != chute);
    
    cout << "Acertou" << endl;
}