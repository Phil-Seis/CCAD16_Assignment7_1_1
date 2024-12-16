/*
 * You are a student who has recently taken an exam with your classmates. However, the professor has not yet provided the students with a sorted list of exam scores. 
 * To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
 * This way, you can obtain the sorted list of scores and see how you performed compared to your classmates. 
 * Also, you choose selection sort since that is an easy way of implementation.
 */

using System;
using System.Security.Cryptography.X509Certificates;

namespace CCAD16_Assignment7_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studGrades = { 99, 85, 88, 100, 75, 65, 69, 73, 92 };
            Console.WriteLine($"The student grades for your class are: {string.Join(", ", studGrades)}");

            SortGrades(studGrades);
            Console.WriteLine($"The student grades sorted for your class are: {string.Join(", ", studGrades)}");
        }

        public static void SortGrades(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minVal = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minVal])
                    {
                        minVal = j;
                    }
                }

                if (minVal != i)
                {
                    int tempVal = array[i];
                    array[i] = array[minVal];
                    array[minVal] = tempVal;
                }
            }
        }
    }
}
