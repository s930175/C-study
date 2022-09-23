using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _86方法綜合練習
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數字");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("請輸入第二個數字");
            string strNumberTwo = Console.ReadLine();
            int numberTwo = GetNumber(strNumberTwo);

            //判斷第一個是否小於第二個
            JudgeNumber(numberOne, numberTwo);
            //求和
            int sum = GetSum(numberOne, numberTwo);
            Console.WriteLine(sum);
            Console.ReadKey();

        }
        /// <summary>
        /// 判斷用戶輸入的是否是數字
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("輸入有誤，請重新輸入");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判斷用戶輸入的數字是否第一個小於第二個
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// 必須加ref，才能將從新輸入的新值帶到外面
        public static void JudgeNumber(ref int n1,ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    //OK
                    return;
                }
                else
                {
                    Console.WriteLine("第一個數字不能大於或等於第二個數字，請重新輸入第一個數字");
                    string s1 = Console.ReadLine();
                    n1 = GetNumber(s1);
                    Console.WriteLine("請重新輸入第二個數字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
