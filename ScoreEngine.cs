using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalScoreChecker;

public static class ScoreEngine
{
    public static int CalculateScore(int[] numbers)
    {
        if (numbers.Length == 0) return 0;

        int totalScore = 0;

        foreach (int number in numbers)
        {
            if (number == 8) totalScore += 5;

            if (number % 2 == 0)
            {
                totalScore += 1;
            }
            else
            {
                totalScore += 3;
            }
        }

        return totalScore;

    }
}
