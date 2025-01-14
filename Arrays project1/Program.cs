using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
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
        static void targil7()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Input(arr1);
            Input(arr2);
            double avg1 = AVG(arr1);
            double avg2 = AVG(arr2);
            double result = avg1 * 100 / avg2;
            if (result >= 25)
            {
                Console.WriteLine("there was a significant improvement");
            }
            else Console.WriteLine("there wasent a significant improvement");

        }
        static void targil6()
        {
            int[] seats = new int[5];
            int seatnumber = 0;
            int num = 1;
            for (int i = 0; i < seats.Length; i++)
            {
                seatnumber = int.Parse(Console.ReadLine());
                if (seats[seatnumber] == 0)
                {
                    Console.WriteLine("you can sit in your chosen seat");
                    seats[seatnumber] = 1;
                }
                else
                    while (seats[seatnumber] != 0)
                    {
                        if (seats[seatnumber + num] == 0)
                        {
                            Console.WriteLine($"you can seat in seatnumber {seatnumber + num}");
                            seats[seatnumber + num] = 1;
                            break;
                        }

                        else if (seats[seatnumber - num] == 0)
                        {
                            Console.WriteLine($"you can seat in {seatnumber - num}");
                            seats[seatnumber - num] = 1;
                            break;
                        }
                        else if (num > seats.Length)
                        {
                            Console.WriteLine("there no seats left");
                        }
                        else num++;


                    }

            }
        }
        static void Targil5()
        {
            int[] Num = new int[40];
            Console.WriteLine("insert 40 numbers");
            Input(Num);
            Array.Sort(Num);
            Console.WriteLine("insert numbers to check if their in the array to stop put -1");
            int input = int.Parse(Console.ReadLine());
            while (input != -1)
            {
                int SearchLocation = Search(Num, input);

                int CaculateSum = 0;

                if (SearchLocation != -1)
                {
                    for (int i = 0; i < SearchLocation; i++) CaculateSum += Num[i];
                    Console.WriteLine($"the number you inputed {input} is located in the array at {SearchLocation}");
                }
                else
                {
                    for (int i = 0; i < Num.Length; i++)
                    {
                        if (Num[i] > input)
                        {
                            SearchLocation = i;
                            break;
                        }
                    }
                    for (int i = 0; i < SearchLocation; i++)
                    {
                        CaculateSum += Num[i];
                    }
                    Console.WriteLine($"the number {input} wasent found the larger number in the array is at {SearchLocation} and the sum of all the numbers before him is {CaculateSum}");
                }
            }

        }
        static int Search(int[] Num, int input)
        {
            for (int i = 0; i < Num.Length; i++)
            {
                if (Num[i] == input) return i;
            }
            return -1;
        }
        static void Targil4()
        {
            int[] N = new int[20];
            int[] M = new int[60];
            Input(M);
            N = CaculateN(N, M);
            WriteOutPut(N);

        }
        static void WriteOutPut(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            Console.WriteLine(N[i]);

        }
        static int[] CaculateN(int[] N, int[] M)
        {
            
            for (int i = 0; i < N.Length; i++)
            {
                int num1 = M[i * 3];
                int num2 = M[i * 3 + 1];
                int code = M[i * 3 + 2];
                if (code == 1) N[i] = num1 + num2;
                else if (code == 2) N[i] = num1 - num2;
                else if (code == 3) N[i] = num1 * num2;
                else if (code == 4) N[i] = num1 / num2;
            }
            return N;
        }
        static void Targil2()
        {
            int[] guess = new int[15];
            int[] result = new int[15];
            Console.WriteLine("insert 15 guesses");
            Input(guess);
            Console.WriteLine("insert 15 result");
            Input(result);
            int CorrectCount = IsCorrect(guess, result);
            Console.WriteLine($"the amount of the correct guesses is {CorrectCount}");
        }
        static int IsCorrect(int[] guess, int[] result)
        {
            int CorrectCount = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == result[i]) CorrectCount++;
            }
            return CorrectCount;
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
