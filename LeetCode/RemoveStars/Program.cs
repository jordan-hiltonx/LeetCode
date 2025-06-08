// https://leetcode.com/problems/removing-stars-from-a-string/description/

string RemoveStars(string s) {
    var stack = new Stack<char>();
    foreach (var c in s) {
        if (c == '*') {
            if (stack.Count > 0) {
                stack.Pop(); // Remove the last character if we encounter a star
            }
        } else {
            stack.Push(c); // Push the current character onto the stack
        }
    }
    return new string(stack.Reverse().ToArray()); // Convert the stack back to a string
}

Console.WriteLine(RemoveStars("leet**cod*e"));