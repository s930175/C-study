using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _56類型轉換
    {
        static void Main(string[] args)
        {
            //使用Convert 進行轉換，Convert會調用Parse方法
            //int numberOne = Convert.ToInt32("123");

            ////使用Parse方法
            //int number = int.Parse("123abc");
            //Console.WriteLine(number);

            //使用TryParse轉換，須加上參數，有返回值。若成功則b = true，number = 123；若失敗則b = false, number = 0
            int number = 100;
            bool b = int.TryParse("123A", out number);
            Console.WriteLine(b);//false
            Console.WriteLine(number);//0
            Console.ReadKey();
        }

    }
}
