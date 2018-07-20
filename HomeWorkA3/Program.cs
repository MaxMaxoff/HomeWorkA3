using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Библиотека для упрощения работы с консолью.
// https://github.com/MaxMaxoff/SupportLibrary
using SupportLibrary;

/// <summary>
/// Максим Торопов
/// Ярославль
/// https://github.com/MaxMaxoff
/// 
/// Домашняя работа "Алгоритмы и структуры данных"
/// 3 урок
/// </summary>
namespace HomeWorkA3
{
    class Program
    {
        /// <summary>
        /// 1. Попробовать оптимизировать пузырьковую сортировку.
        /// Сравнить количество операций сравнения оптимизированной и не оптимизированной программы.
        /// Написать функции сортировки, которые возвращают количество операций.
        /// </summary>
        static void Task1()
        {
            SupportMethods.PrepareConsoleForHomeTask("1. Попробовать оптимизировать пузырьковую сортировку.\n" +
                "Сравнить количество операций сравнения оптимизированной и не оптимизированной программы.\n" +
                "Написать функции сортировки, которые возвращают количество операций.\n");

            //int arrsize = SupportMethods.RequestIntValue("Please type size of array: ");
            //int min = SupportMethods.RequestIntValue("Please type min value of element: ");
            //int max = SupportMethods.RequestIntValue("Please type max value of element: ");

            int arrsize = 10000;
            int min = 0;
            int max = 10000;

            MyArray arrBS = new MyArray(arrsize, min, max);
            MyArray arrBSO = new MyArray(arrsize);
            MyArray arrBSSO = new MyArray(arrsize);
            MyArray arrBSSOS = new MyArray(arrsize);
            
            Array.Copy(arrBS.GetArray, arrBSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrBSSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrBSSOS.GetArray, arrsize);

            // Print out array
            // SupportMethods.Pause($"Array:\n{arrBS.ToString()}\nPress any key to continue...\n");

            // ********************************
            // Bubble Sort
            int rounds = 0;
            int steps = 0;

            Console.WriteLine("Bubble Sort");
            DateTime dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrBS.BubbleSort(ref rounds, ref steps);

            DateTime dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            //SupportMethods.Pause($"Sorted array using Bubble Sort:\n{arrBS.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");            
            SupportMethods.Pause($"Sorted: {arrBS.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Bubble Sort Optimized using flag
            rounds = 0;
            steps = 0;

            Console.WriteLine("Bubble Sort Optimized using flag");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrBSO.BubbleSortOptimized(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            // SupportMethods.Pause($"Sorted array using Bubble Sort Optimized:\n{arrBSO.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrBSO.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Bubble Sort optimized using false Shaker sort and flag
            rounds = 0;
            steps = 0;

            Console.WriteLine("Bubble Sort optimized using false Shaker sort and flag");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrBSSO.BubbleShakeSortOptimized(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            // SupportMethods.Pause($"Sorted array using Bubble Sort Optimized:\n{arrBSSO.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrBSSO.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Bubble Sort optimized using false Shaker sort, flag and optimization size of array
            rounds = 0;
            steps = 0;

            Console.WriteLine("Bubble Sort optimized using false Shaker sort, flag and optimization size of array");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrBSSOS.BubbleShakeSortOptimizedSecond(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            // SupportMethods.Pause($"Sorted array using Bubble Sort Optimized and array size optimizing:\n{arrBSSOS.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrBSSOS.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
        }

        /// <summary>
        /// 2. *Реализовать шейкерную сортировку.
        /// </summary>
        static void Task2()
        {
            SupportMethods.PrepareConsoleForHomeTask("2. *Реализовать шейкерную сортировку.\n");
            
            //int arrsize = SupportMethods.RequestIntValue("Please type size of array: ");
            //int min = SupportMethods.RequestIntValue("Please type min value of element: ");
            //int max = SupportMethods.RequestIntValue("Please type max value of element: ");

            int arrsize = 10000;
            int min = 0;
            int max = 10000;

            MyArray arrSS = new MyArray(arrsize, min, max);
            MyArray arrSSO = new MyArray(arrsize);
            MyArray arrSSSO = new MyArray(arrsize);
            MyArray arrSSSOS = new MyArray(arrsize);

            Array.Copy(arrSS.GetArray, arrSSO.GetArray, arrsize);
            Array.Copy(arrSS.GetArray, arrSSSO.GetArray, arrsize);
            Array.Copy(arrSS.GetArray, arrSSSOS.GetArray, arrsize);

            // Print out array
            // SupportMethods.Pause($"Array:\n{arrSS.ToString()}\nPress any key to continue...\n");

            // ********************************
            // Shaker Sort
            int rounds = 0;
            int steps = 0;

            Console.WriteLine("Shaker Sort");
            DateTime dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrSS.ShakerSort(ref rounds, ref steps);

            DateTime dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            //SupportMethods.Pause($"Sorted array using Bubble Sort:\n{arrSS.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrSS.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Shaker Sort Optimized using flag
            rounds = 0;
            steps = 0;

            Console.WriteLine("Shaker Sort Optimized using flag");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrSSO.ShakerSortOptimized(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            //SupportMethods.Pause($"Sorted array using Bubble Sort:\n{arrSSO.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrSSO.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Shaker Sort Optimized using false Shaker sort and flag
            rounds = 0;
            steps = 0;

            Console.WriteLine("Shaker Sort Optimized using false Shaker sort and flag");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrSSSO.ShakerShakeSortOptimized(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            //SupportMethods.Pause($"Sorted array using Bubble Sort:\n{arrSSSO.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrSSSO.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

            // ********************************
            // Shaker Sort Optimized using false Shaker sort, flag and optimization size of array
            rounds = 0;
            steps = 0;

            Console.WriteLine("Shaker Sort Optimized using false Shaker sort, flag and optimization size of array");
            dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arrSSSOS.ShakerShakeSortOptimizedSecond(ref rounds, ref steps);

            dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            //SupportMethods.Pause($"Sorted array using Bubble Sort:\n{arrSSSOS.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
            SupportMethods.Pause($"Sorted: {arrSSSOS.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");
        }

        /// <summary>
        /// 3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив.
        /// Функция возвращает индекс найденного элемента или -1, если элемент не найден.
        /// </summary>
        static void Task3()
        {
            int arrsize = 100;
            int min = 0;
            int max = 1000;
            int rounds = 0;
            int steps = 0;
            SupportMethods.PrepareConsoleForHomeTask("3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив.\n" +
                "Функция возвращает индекс найденного элемента или -1, если элемент не найден.\n");
            
            MyArray arr = new MyArray(arrsize, min, max);
            arr.ShakerShakeSortOptimizedSecond(ref rounds, ref steps);

            // Print out array
            Console.WriteLine($"Array:\n{arr.ToString()}\n");

            int value = SupportMethods.RequestIntValue("Please type value: ");

            int index = arr.IndexOf(arr.GetArray, value);

            SupportMethods.Pause(index == -1 ? "Element not found" : $"Index of {value} is {index}");
        }

        /// <summary>
        /// 4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.
        /// </summary>
        static void Task4()
        {
            SupportMethods.PrepareConsoleForHomeTask("4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.\n");

            //int arrsize = SupportMethods.RequestIntValue("Please type size of array: ");
            //int min = SupportMethods.RequestIntValue("Please type min value of element: ");
            //int max = SupportMethods.RequestIntValue("Please type max value of element: ");

            int arrsize = 10000;
            int min = 0;
            int max = 10000;

            MyArray arrBS = new MyArray(arrsize, min, max);
            MyArray arrBSO = new MyArray(arrsize);
            MyArray arrBSSO = new MyArray(arrsize);
            MyArray arrBSSOS = new MyArray(arrsize);
            MyArray arrSS = new MyArray(arrsize);
            MyArray arrSSO = new MyArray(arrsize);
            MyArray arrSSSO = new MyArray(arrsize);
            MyArray arrSSSOS = new MyArray(arrsize);

            Array.Copy(arrBS.GetArray, arrBSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrBSSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrBSSOS.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrSS.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrSSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrSSSO.GetArray, arrsize);
            Array.Copy(arrBS.GetArray, arrSSSOS.GetArray, arrsize);

            int asymptoticComplexityRounds = arrsize;
            int asymptoticComplexitySteps = arrsize * arrsize;

            int rounds = 0;
            int steps = 0;

            arrBS.BubbleSort(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrBSO.BubbleSortOptimized(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrBSSO.BubbleShakeSortOptimized(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrBSSOS.BubbleShakeSortOptimizedSecond(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrSS.ShakerSort(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrSSO.ShakerSortOptimized(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrSSSO.ShakerShakeSortOptimized(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            rounds = 0;
            steps = 0;

            arrSSSOS.ShakerShakeSortOptimizedSecond(ref rounds, ref steps);
            Console.WriteLine($"Rounds Real: {rounds}, Asymptotic Complexity Rounds: {asymptoticComplexityRounds} | Steps Real: {steps}, Asymptotic Complexity Steps: {asymptoticComplexitySteps}");

            SupportMethods.Pause();
        }

        static void Main(string[] args)
        {
            do
            {
                SupportMethods.PrepareConsoleForHomeTask("1 - Task 1\n" +
                  "2 - Task 2\n" +
                  "3 - Task 3\n" +
                  "4 - Task 4\n" +
                  "0 (Esc) - Exit\n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                        Task3();
                        break;
                    case ConsoleKey.D4:
                        Task4();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
