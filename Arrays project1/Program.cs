using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
        static void Targil3()
        {
            Console.WriteLine("insert 14 numbers");
            int[] numbers = new int[14];
            Inputnumbers(numbers);
            int maxnumber = Max(numbers);
            int maxlocation = LocationMax(numbers);
            Console.WriteLine($"max number is {maxnumber} \n location of max number is {maxlocation}");

        }
        static void Inputnumbers(int[] numbers) { for (int i = 0; i < numbers.Length; i ++) { numbers[i] = int.Parse(Console.ReadLine()); } }
        static int LocationMax(int[] numbers)
        {
            int max = numbers[0];
            int locationmax = 0;
            for (int i = 1; i < numbers.Length; i++)
            {                
                if (max < numbers[i])
                {
                    locationmax = i + 1;
                    max = numbers[i];
                }
            }
            return locationmax;
        }
        static int Max(int[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                max = Math.Max(max, numbers[i]);
            }
            return max;
        }
        static void Targil1()
        {
            Console.WriteLine("insert 10 grades");
            int[] grades = new int[10];
            Input(grades);
            double avg = AVG(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(distance(grades[i], avg));
            }

        }
        static void Input(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }
        }
        static double AVG(int[] grades) 
        {
            int sum = 0;
            for (int i = 0;i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return (double)sum / grades.Length;
        }
        static double distance(int grades, double avg) 
        {
            return Math.Abs(grades - avg);
        }
    }
}
