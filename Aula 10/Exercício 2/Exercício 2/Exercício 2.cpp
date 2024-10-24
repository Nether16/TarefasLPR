#include <iostream>
#include <random>
#include <list>
using namespace std;
int main()
{
    srand(time(0));

    list<int> nums;
    for (int i = 0;i < 100;i++) {
        nums.push_back(rand() % 100);
    }

    nums.sort();
    for (auto num : nums) {
        cout << num << " ";
    }

    cout << endl << endl;

    auto it = nums.begin();
    for (auto num : nums) {
        advance(it, 1);
        if (!(*it % 2 == 0)) {
            cout << *it << " ";
        }
    }

    cout << endl << endl;

    it = nums.begin();
    auto it2 = nums.begin();
    advance(it2, 1);
    for (auto num : nums) {
        advance(it, 1);      
        advance(it2, 1);
        if (*it != *it2) {
            cout << *it << " ";
        }
    }
}