using System;

internal class SolutionQ1
{
    public int Solution(int[] A)
    {
        int smallest = int.MaxValue;
        bool found = false;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > 0 && A[i] < smallest)
            {
                smallest = A[i];
                found = true;
            }
        }

        if (found == true)
        {
            return smallest * smallest;
        }
        else
        {
            return 0;
        }
    }
}

