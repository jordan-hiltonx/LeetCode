// https://leetcode.com/problems/valid-sudoku/description/

using System.Diagnostics;

var res = true;
var v = new List<(int, int)>();
var sq = new List<int>();
var cCount = 1;
var cStart = 0;
var rStart = 0;
var rCount = 3;
var sw = new Stopwatch();

void IsValidSudoku(char[][] board)
{
    sw.Start();
    for (int r = 0; r < board.Length; r++) // looping arrays
    {
        foreach (var digit in board[r]) // looping digits horizontally
        {
            if (int.TryParse(digit.ToString(), out int number))
            {
                List<int> dupes = new List<int>();
                Dictionary<int, int> counts = new Dictionary<int, int>();

                foreach (var num in board[r])
                {
                    if (counts.ContainsKey(num))
                    {
                        counts[num]++;
                    }
                    else
                    {
                        counts[num] = 1;
                    }
                }

                foreach (var pair in counts)
                {
                    if (pair.Value > 1)
                    {
                        dupes.Add(pair.Key);
                    }
                }
                if (dupes.Count > 1)
                {
                    res = false;
                }
            }
        }
    }
    
    // loops vertically through whole board
    for (int c = 0; c < cCount; c++) 
    { 
        for (int r = 0; r < board.Length; r++)
        {
            if (!int.TryParse(board[r][c].ToString(), out int num)) continue;
            if (v.Contains((num, c)))
            {
                res = false;
            }
            else
            {
                v.Add((num, c));
            }
        }
        if (cCount <= 8)
        {
            cCount++;
        }
    }
    
    cCount = 3;
    // loops through 3x3 square through whole board
    while (cCount <= 9 || rCount < 9)
    {
        for (int c = cStart; c < cCount; c++)
        {                                 
            for (int r = rStart; r < rCount; r++)
            {
                if (int.TryParse(board[r][c].ToString(), out int number))
                {
                    sq.Add(number);
                }
            }
        }
        var squareHasDuplicate = sq.GroupBy(x => x).Any(g => g.Count() > 1);
        if (squareHasDuplicate)
        {
            res = false;
        }
    
        sq.Clear();
        if (cCount <= 9 && cStart <= 9)
        {
            cCount += 3;
            cStart += 3;
        }

        if (cCount < 9 || cStart <= 6 || rCount > 9 || rStart > 6 || rCount ! >= 9) continue;
        cCount = 3;
        cStart = 0;
        rCount += 3;
        rStart += 3;
    }
    

    Console.WriteLine(res);
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds); 
    //return result;
}

IsValidSudoku(
 [['5','3','.','.','7','.','.','.','.'],
        ['6','.','.','1','9','5','.','.','.'],
        ['.','9','8','.','.','.','.','6','.'],
        ['8','.','.','.','6','.','.','.','3'],
        ['4','.','.','8','.','3','.','.','1'],
        ['7','.','.','.','2','.','.','.','6'],
        ['.','6','.','.','.','.','2','8','.'],
        ['.','.','.','4','1','9','.','.','5'],
        ['.','.','.','.','8','.','.','7','9']]
    );
