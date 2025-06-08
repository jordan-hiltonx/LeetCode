// https://leetcode.com/problems/check-if-number-is-a-sum-of-powers-of-three/description/

bool CheckPowersOfThree(int n) {
    while (n > 0) {
        if (n % 3 == 2) {
            return false; // If n has a digit '2' in base 3, it cannot be expressed as a sum of powers of three
        }
        n /= 3; // Divide n by 3 to check the next digit
    }
    return true; // If we finish the loop without finding a '2', it can be expressed as a sum of powers of three
}

Console.WriteLine(CheckPowersOfThree((21)));