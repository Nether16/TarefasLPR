#include <iostream>
using namespace std;
int main()
{
    int soma = 0;
        
    for (int i = 50; i < 500; i++){
        int divisivel = i % 3;
        int impar = i % 2;
        
        if (divisivel == 0){
            if(impar == 1){
                soma += i;
                cout << soma << endl;
            }
        }
    }
}