// https://leetcode.com/problems/powx-n/description/

using System.Diagnostics;

var sw = new Stopwatch();

double MyPow(double x, int n) {
    sw.Start();
    var pow = Math.Pow(x, n);
    sw.Stop();
    return pow;
}

Console.WriteLine(MyPow(2.00000, 10));
