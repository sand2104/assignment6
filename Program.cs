using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the jagged array
            int[][] studentScores = new int[3][];

            // Initialize the scores for each student with respective numbers are given
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            // Print the scores of each student
            Console.WriteLine("Student Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write("Student " + (i + 1) + ": ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Calculate and print the average score for each student
            Console.WriteLine("Average Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++) //Using Nested Loop
                {
                    sum += studentScores[i][j];
                }
                double average = sum / studentScores[i].Length;
                Console.WriteLine("Student " + (i + 1) + ": " + average);
            }

            Console.WriteLine();

            // Calculate and print the average score for all students combined
            Console.WriteLine("Average Score for All Students Combined:");
            double totalSum = 0;
            int totalLength = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalLength++;
                }
            }
            double totalAverage = totalSum / totalLength;
            Console.WriteLine(totalAverage);
        }
    }
}