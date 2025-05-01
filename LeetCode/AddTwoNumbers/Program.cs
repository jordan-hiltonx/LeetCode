/// summary
/// You are given two non-empty linked lists representing two non-negative integers.
/// The digits are stored in reverse order, and each of their nodes contains a single digit.
/// Add the two numbers and return the sum as a linked list.
/// summary


using System.Text;

List<int> l1 = new List<int>() {2, 4, 3};
var l1String = new StringBuilder();
int l1int;

List<int> l2 = new List<int>() {5, 6}; // 342 + 465 = 807 
var l2String = new StringBuilder();
int l2int;

l1.Reverse();
foreach (var num in l1)
{
    l1String.Append(num);
}
int.TryParse(l1String.ToString(), out l1int);

l2.Reverse();
foreach (var num in l2)
{
    l2String.Append(num);
}
int.TryParse(l2String.ToString(), out l2int);

var mathResult = l1int + l2int;

var strMathRes = mathResult.ToString();

foreach (var item in strMathRes.Reverse().ToArray())
{
    int.TryParse(item.ToString(), out var num);
    Console.WriteLine(num);
}

