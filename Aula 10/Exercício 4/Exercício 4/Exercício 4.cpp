#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, int> Ages;

    int media = 0, old = 0, young = 0;
    string O = "", Y = "";
    cout << "Insira a quantidade de pessoas a serem adicionadas :" << endl;
    int quant;
    cin >> quant;

    for (int i = 0; i < quant; i++) {
        string name;
        int age;

        cout << "Insira o nome da pessoa :" << endl;
        cin >> name;
        cout << "Insira a idade da pessoa :" << endl;
        cin >> age;

        Ages[name] = age;
        media += age;
    }

    media = media / quant;

    for (auto& p : Ages) {
        if (p.second < young || young == 0) {
            young = p.second;
            Y = p.first;
        }
        if (p.second > old) {
            old = p.second;
            O = p.first;
        }
    }

    cout << "Pessoa com a idade acima da media (" << media << ")" << endl;
    for (auto& p : Ages) {
        if (p.second > media) {
            cout << "Pessoa: " << p.first << ", Idade: " << p.second << endl;
        }
    }

    cout << "\nPessoa mais nova e " << Y << " com " << young << " anos" << endl;
    cout << "Pessoa mais velha e " << O << " com " << old << " anos" << endl;

    cout << "Insira uma idade para ser removida :" << endl;
    int remove;
    cin >> remove;

    cout << "Dicionario atualizado :" << endl;
    for (auto& p : Ages) {
        if (p.second != remove) {
            cout << "Pessoa: " << p.first << ", Idade: " << p.second << endl;
        }
    }

    return 0;
}