using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A); 
        int minPosotivieTillyet = 1; 
        foreach(int i in A)
        {
            if (i <= 0) continue;
            else if (i == minPosotivieTillyet)
            {
                minPosotivieTillyet += 1; 
            }

        }

        return minPosotivieTillyet; 
    }

    public static void Main(String[] args)
    {
        int[] A = { 2, 1, 3, 4, 6 };
        Solution s = new Solution();
        int answer = s.solution(A); 
    }
}
