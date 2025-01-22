
using TotalScoreChecker;

int[] testCaseOne = {1, 2, 3, 4, 5};
int[] testCaseTwo = { 15, 25, 35 };
int[] testCaseThree = { 8, 8 };

int TestCaseOneScore = ScoreEngine.CalculateScore(testCaseOne);
int TestCaseTwoScore = ScoreEngine.CalculateScore(testCaseTwo);
int TestCaseThreeScore = ScoreEngine.CalculateScore(testCaseThree);

Console.WriteLine($"The Score for {string.Join(", ", testCaseOne)} is: {TestCaseOneScore}");
Console.WriteLine($"The Score for {string.Join(", ", testCaseTwo)} is: {TestCaseTwoScore}");
Console.WriteLine($"The Score for {string.Join(", ", testCaseThree)} is: {TestCaseThreeScore}");