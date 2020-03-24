/*
 * Jesse Hauck
 * August 20, 2019
 * Gets tests scores from the user, finds the average,
 * then displays the average followed by all the scores
 * and if it is higher or lower than the average
 */

using System;
using static System.Console;
using static System.Array;

namespace TestScoreList
{
    class Program
    {
        static void Main()
        {
            // an array for storing the test scores
            int[] testScores;
            // an int for the number of scores
            int scoreNumbers;
            // another int for the total and a doubles for the average and displacement
            double totalScore = 0;
            double averageScore;
            double position;
            // string for above or below the average
            string upDown;

            // message to the user, and getting the number of scores
            WriteLine("Test Score Averager");
            Write("How many scores do you want to average? ");
            scoreNumbers = Convert.ToInt32(ReadLine());

            // creating the array with the size from the user
            testScores = new int[scoreNumbers];

            // getting the scores from the user and storing them in the array
            for (int i = 0; i < scoreNumbers; ++i)
            {
                Write("Please enter score {0}: ", (i + 1));
                testScores[i] = Convert.ToInt32(ReadLine());
            }

            // sorting the scores
            Sort(testScores);

            // finding the average
            foreach (int score in testScores)
            {
                totalScore += score;
            }
            averageScore = totalScore / scoreNumbers;

            // displaying all of the scores and their distance from the average
            WriteLine("\n\nThe average is {0}, and here are your scores:", averageScore.ToString("N1"));
            WriteLine("{0,-10}{1,10}", "Score", "Distance from Average");
            foreach (int score in testScores)
            {
                // finding if each score is greater than or less than the average
                position = averageScore - score;
                if (position < 0)
                {
                    position *= -1;
                    upDown = "Above Average";
                }
                else if (position > 0)
                {
                    upDown = "Below Average";
                }
                else upDown = "Average";
                WriteLine("{0,-10}{1,3} {2,10}", score, position.ToString("N1"), upDown);
            }

            WriteLine("\n\n\n");
        }
    }
}
