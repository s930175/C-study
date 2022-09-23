using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _72方法
    {
        //C#中沒有全局變量，但能用字段模擬全局變量
        //字段 屬於類的字段
        public static int _number = 10;
        static void Main(string[] args)
        {
            //方法
            //[public] static 返回值類型 方法名([參數列表])
            //公開的    靜態的 如果沒有返回值就void，有就寫返回值類型 方法名首字母大寫，參數列表為必須要提供給方法的條件
            //return 立即結束方法，並返回值
            //方法寫完在Main中調用
            //類名.方法名 來調用
            int max = _72方法.GetMax(1,2);
            Console.WriteLine(max);
            Console.ReadKey();

            // 在某些情況下，調用方法時類名可省略:若寫的方法跟Main()在同一個類中，這時可省略
            
            
            
            //傳參
            int a = 3;
            int b = 5;
            Test(a);
            int res = Test2(b);
            Console.WriteLine(a);//3 因為void沒有返回值
            Console.WriteLine(res);//10
            Console.WriteLine(_number);
            Console.ReadKey();
            
        }
        public static void Test(int a)
        {
            a = a + 5;
        }
        public static int Test2(int b)
        {
            return b = b + 5;
        }

        //計算兩整數間的最大值，並返回最大值
        /// <summary>
        /// 計算兩整數間的最大值，並返回最大值
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;

        }

        

    }
}
