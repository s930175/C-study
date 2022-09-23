using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _76方法練習
    {
        static void Main(string[] args)
        {
            bool b = IsRun(2000);
            Console.WriteLine(b);
            Console.ReadKey();
            //GetNumber();
            //----------------------------------
            Console.WriteLine("請輸入數字");
            string input = Console.ReadLine();
            int value = GetNumber(input);
            Console.WriteLine(value);
            Console.ReadKey();
            //----------------------------------
            Console.WriteLine("請輸入yes or no");
            string yesOrNo = Console.ReadLine();
            string result = IsYesOrNo(yesOrNo);
            Console.WriteLine(result);
            Console.ReadKey();
            //----------------------------------
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();

        }
        /// <summary>
        /// 用戶輸入，若是數字則返回數字，若不是數字則重複循環
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetNumber(string input)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(input);
                    return number;
                }
                catch 
                {
                    Console.WriteLine("請重新輸入");
                    //重新接收input，否則陷入死循環
                    input = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 只許輸入yes或no，並且返回
        /// </summary>
        /// <param name="input">用戶輸入</param>
        /// <returns>用戶返回</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else 
                {
                    Console.WriteLine("只能輸入yes or no,請重新輸入");
                    input = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 用戶輸入，若是數字則返回數字，若不是數字則重複循環
        /// </summary>
        //public static void GetNumber()
        //{
        //    while (true)
        //    {
        //        //勿在方法中提示輸入，否則調用會被侷限
        //        Console.WriteLine("請輸入數字");
        //        try
        //        {
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine(number);
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("輸入錯誤");
        //        }
        //    }
        //}

        /// <summary>
        /// 判斷給定的年份是否為閏年
        /// </summary>
        /// <param name="year">要判斷的年份</param>
        /// <returns>是否是閏年</returns>
        public static bool IsRun(int year)
        {
            bool b = ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0));
            return b;
        }

        /// <summary>
        /// 計算一個整數類型數組的總和
        /// </summary>
        /// <param name="nums">要求總和的數組</param>
        /// <returns>數組總和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0;i<nums.Length;i++)
            {
                sum += nums[i];
            }
            return sum;
        }

      
    }
}
