using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                runApp(); 
            }

            static void SelectionSort(int[] arr)
            {

            
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                    }

                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            static void DisplayArray(int[] arr)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            public static void runApp()
            {
                int[] students = { 45, 72, 33, 19, 56 };
            Console.WriteLine("-----Selection Sort-----");
                Console.WriteLine("Original Array:");
                DisplayArray(students);

                SelectionSort(students);
            

                Console.WriteLine("\nSorted Array:");
                DisplayArray(students);
            Console.ReadLine();
            }
        }
    }


