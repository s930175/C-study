using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _79out參數
    {
        // out 參數:
        // 如果在一個方法中，返回多個相同類型的值的時候，可以考慮返回一個數組。
        // 但是，如果返回多個不同類型的值的時候，返回數組就不行了，這時候可以考慮使用out參數。
        // out參數側重於在一個方法中可以返回多個不同類型的值。
        // out 像是多餘返回的參數
        // 方法內需先將out 參數賦值
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] res = GetMaxMinSumAvg(numbers);
            Console.WriteLine("Max{0},Min{1},Sum{2},Avg{3}", res[0], res[1], res[2], res[3]);
            Console.ReadKey();
            int max1;
            int min1;
            int sum1;
            int avg1;
            bool b;
            string s;
            double d;
            Test(numbers, out max1, out min1, out sum1, out avg1, out b, out s, out d);
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.ReadKey();
        }
        /// <summary>
        /// 計算最大值 最小值 總和 平均
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假設 res[0] 最大值 res[1] 最小值 res[2] 總和 res[3] 平均值
            res[0] = nums[0];//max
            res[1] = nums[0];//min
            res[2] = 0;//sum
            for (int i = 0;i<nums.Length;i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[0])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            //平均值
            res[3] = res[2] / nums.Length;
            return res;
        }
        /// <summary>
        /// 利用out計算最大值 最小值 總和 平均值 
        /// </summary>
        /// <param name="nums">要求值的數組</param>
        /// <param name="max">多餘返回的最大值</param>
        /// <param name="min">多餘返回的最小值</param>
        /// <param name="sum">多餘返回的總和</param>
        /// <param name="avg">多餘返回的平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg,out bool b, out string s, out double d)
        {
            //out 參數要求在方法內部必須為其賦值
            max = nums[0];
            min = nums[0];
            sum = 0;
            b = true;
            s = "123";
            d = 3.14;
            for (int i = 0;i<nums.Length;i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }

}
