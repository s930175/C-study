using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _87方法練習
    {
        static void Main(string[] args)
        {
            string[] names = { "JON", "TOMMONY", "JONE", "ANY" };
            string max = GetLongest(names);
            Console.WriteLine(max);
            Console.ReadKey();

            int[] numbers = { 1, 2, 7 };
            double avg = GetAvg(numbers);
            //保留兩位小數
            string s = avg.ToString("0.00");
            Console.WriteLine(s);
            avg = Convert.ToDouble(s);
            Console.WriteLine(avg);
            //另一種方法
            //Console.WriteLine("{0:0.00}",avg);
            Console.ReadKey();


            //----------------------------------
            Console.WriteLine("輸入數字，判斷是否為質數");
            string strNumber = Console.ReadLine();

            int number = GetNumber(strNumber);
            bool b = IsPrime(number);
            Console.WriteLine(b);
            Console.ReadKey();

            //-------------------------------------
            string[] names2 = { "01", "21", "31", "41" };
            Test(names2);
            for (int i = 0;i<names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();

            //-----------------------------------------
            double r = 5;
            double perimeter;
            double area;
            GetPerimeterArea(r, out perimeter, out area);

            //-----------------------------------------
            int sum = GetSum(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
            Console.ReadKey();

            //----------------------------------------
            int[] nums = { 1, 2, 4, 6, 2, 5, 7, 10, 43, 34 };
            Change(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();

            //-------------------------------------------
            string[] names3 = { "JON", "TOMMONY", "JONE", "ANY" };
            string str = ProcessString(names3);
            Console.WriteLine(str);
            Console.ReadKey();

        }
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("請重新輸入");
                    strNumber = Console.ReadLine();
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else 
            {
                //從2開始除，除到自身的前一位
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        //給非質數準備的
                        return false;
                    }
                    //不可在這返回true
                    //else
                    //{
                    //    return true;
                    //}
                }
                //給質數準備的
                return true;
            }
        }

        //數組類型，若方法中有改變數組順序 元素位置 大小 不需要寫返回值
        public static void Test(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
        }

        public static void GetPerimeterArea(double r, out double perimeter, out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }

        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static void Change(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        public static string ProcessString(string[] names)
        {
            string str = null;
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            return str + names[names.Length - 1];
        }
    }
}
