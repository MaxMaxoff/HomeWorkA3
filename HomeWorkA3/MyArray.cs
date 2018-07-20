﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA3
{
    class MyArray
    {
        /// <summary>
        /// create new array
        /// </summary>
        int[] a;

        /// <summary>
        /// initialize empty array
        /// </summary>
        public MyArray(int n)
        {
            a = new int[n];
        }

        /// <summary>
        /// initialize array with requested params
        /// </summary>
        /// <param name="n">size of array</param>
        /// <param name="min">min value of array element</param>
        /// <param name="max">max value of array element</param>
        public MyArray(int n, int min, int max) : this(n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
                a[i] = random.Next(min, max + 1);
        }

        /// <summary>
        /// Properties return array
        /// </summary>
        public int[] GetArray
        {
            get
            {
                return a;
            }
        }

        /// <summary>
        /// Properties return status of array
        /// </summary>
        public bool isSorted
        {
            get
            {
                bool flag = true;
                for (int i = 0; i < a.Length - 1; i++)
                    if (a[i] > a[i + 1]) flag = false;
                return flag;
            }
        }

        /// <summary>
        /// Method Swap values
        /// </summary>
        public void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        /// <summary>
        /// Method Bubble Sort
        /// </summary>
        public void BubbleSort(ref int rounds, ref int steps)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[j] > a[j + 1]) Swap(ref a[j], ref a[j + 1]);

            steps = a.Length * (a.Length - 1);
            rounds = a.Length;
        }

        /// <summary>
        /// Method Bubble Sort Optimized
        /// </summary>
        public void BubbleSortOptimized(ref int rounds, ref int steps)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        flag = true;
                        Swap(ref a[j], ref a[j + 1]);
                    }                    
                }
                rounds++;
            }
            steps = rounds * (a.Length - 1);
        }

        /// <summary>
        /// Method BubbleShake Sort Optimized
        /// </summary>
        public void BubbleShakeSortOptimized(ref int rounds, ref int steps)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int j = 0;  j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        flag = true;
                        Swap(ref a[j], ref a[j + 1]);
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {
                        flag = true;
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                    }                    
                }
                rounds++;
            }
            steps = rounds * (a.Length - 1);
        }

        /// <summary>
        /// Method BubbleShake Sort&Size Optimized
        /// </summary>
        public void BubbleShakeSortOptimizedSecond(ref int rounds, ref int steps)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;                
                for (int j = rounds; j < a.Length - rounds - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        flag = true;
                        Swap(ref a[j], ref a[j + 1]);
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {
                        flag = true;
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                    }
                }
                rounds++;
            }
            steps = rounds * (a.Length - rounds - 1);
        }

        /// <summary>
        /// Method Shaker Sort
        /// </summary>
        public void ShakerSort(ref int rounds, ref int steps)
        {
            for (int i = 0; i < a.Length / 2 + 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[j] > a[j + 1]) Swap(ref a[j], ref a[j + 1]);
                for (int j = a.Length - 2; j > 0; j--)
                    if (a[j] > a[j + 1]) Swap(ref a[j], ref a[j + 1]);
            }

            rounds = a.Length / 2;
            steps = rounds * (a.Length - 1) + rounds * (a.Length - 1);
        }

        /// <summary>
        /// Method Shaker Sort Optimized
        /// </summary>
        public void ShakerSortOptimized(ref int rounds, ref int steps)
        {
            int halfRounds = 0;
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                }
                halfRounds++;
                if (!flag) break;
                
                flag = false;
                for (int j = a.Length - 2; j > 0; j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                }
                rounds++;
            }
            rounds += halfRounds;
            steps = rounds * (a.Length - 2) + halfRounds * (a.Length - 1);            
        }

        /// <summary>
        /// Method Shaker Shake Sort Optimized
        /// </summary>
        public void ShakerShakeSortOptimized(ref int rounds, ref int steps)
        {
            int halfRounds = 0;
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int j = 0;  j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                        flag = true;
                    }
                }
                halfRounds++;
                if (!flag) break;

                flag = false;                
                for (int j = a.Length - 2; j > 0; j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                        flag = true;
                    }
                }
                rounds++;
            }
            rounds += halfRounds;
            steps = rounds * (a.Length - 2) + halfRounds * (a.Length - 1);
        }

        /// <summary>
        /// Method Shaker Shake Sort&Size Optimized
        /// </summary>
        public void ShakerShakeSortOptimizedSecond(ref int rounds, ref int steps)
        {
            int halfRounds = 0;

            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int j = rounds + halfRounds;  j < a.Length - (rounds + halfRounds) - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                        flag = true;
                    }
                }
                halfRounds++;
                if (!flag) break;

                flag = false;                
                for (int j = a.Length - (rounds + halfRounds) - 2; j > (rounds + halfRounds - 1); j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        flag = true;
                    }
                    if (a[a.Length - j - 2] > a[a.Length - j - 1])
                    {                        
                        Swap(ref a[a.Length - j - 2], ref a[a.Length - j - 1]);
                        flag = true;
                    }
                }
                rounds++;
            }
            rounds += halfRounds;
            steps = rounds * (a.Length - (rounds + halfRounds - 1) - 2) + halfRounds * (a.Length - (rounds + halfRounds) - 1);
        }

        /// <summary>
        /// Method IndexOf element, search element in array using binary search
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="value">element</param>
        /// <returns>index of element in array</returns>
        public int IndexOf(int[] arr, int value)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;
            int curIndex = arr.Length / 2;

            while (arr[curIndex] != value && leftIndex <= rightIndex)
            {
                if (arr[curIndex] > value)
                    rightIndex = curIndex - 1;
                else if (arr[curIndex] < value)
                    leftIndex = curIndex + 1;

                curIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Console.WriteLine($"{leftIndex} {curIndex} {rightIndex}");
            }

            if (arr[curIndex] == value) return curIndex;
            else return -1;
        }

        /// <summary>
        /// prepare string for print out array elements
        /// </summary>
        /// <returns>string of array's elements</returns>
        public override string ToString()
        {
            string t = String.Empty;
            for (int i = 0; i < a.Length; i++)
                t = t + a[i].ToString() + " ";
            return t;
        }
    }
}
