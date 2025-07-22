using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class SolutionQ3
    {
        public int solution(int[] A)
        {
            int sum = 0;
            foreach (int number in A)
            {
                if (number == 0)
                    break;
                if (number > 0)
                    sum += number;
            }
            return sum;
        }
    }
}


