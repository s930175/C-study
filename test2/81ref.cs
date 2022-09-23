using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _81ref
    {
        // ref
        // 能夠將一個變量帶入一個方法中進行改變，改變完成後，再將改變後的值帶出方法(自帶return)
        // 要求再方法外必須先為其賦值，方法內可以不賦值
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();

            //使用方法將兩個int類型變量交換
            int n1 = 10;
            int n2 = 20;
            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            Test(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();


        }
        public static void JiangJin(ref double s)
        {
            s += 500;
        }
        public static void FaKuan(double s)
        {
            s -= 500;
        }

        public static void Test(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
