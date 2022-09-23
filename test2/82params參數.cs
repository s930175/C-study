using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _82params參數
    {
        //params 可變參數
        //將實參列表中 跟 可變參數數組類型一致的元素 都當作數組的元素去處理
        //params必須是形參列表中最後一個參數
        static void Main(string[] args)
        {
            int[] s = { 99, 88, 77 };
            Test("張三", 10, 99, 88, 77);
            Test("張三", 10, s);
            Console.ReadKey();


            //求任意長度數組的合 整數類型的
            int sum = GetSum(1,2,3,4,5);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static void Test(string name, int id,params int[] score)
        {
            int sum = 0;
            for (int i = 0;i<score.Length;i++)
            {
                sum += score[i];

            }
            Console.WriteLine("{0}這次的考試總成績是{1},學號是{2}", name, sum, id);
        }

        public static int GetSum(params int[] n)
        {
            int sum = 0;
            for (int i = 0;i<n.Length;i++)
            {
                sum += n[i];
            }
            return sum;
        }
    }
}
