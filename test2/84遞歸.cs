using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _84遞歸
    {
        //方法自己調用自己
        //需有個條件來停止調用
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadKey();
        }

        public static int i = 0;//設置靜態字段，讓i不會重複賦值成0
        public static void TellStory()
        {
            //int i = 0;
            Console.WriteLine("000");
            Console.WriteLine("111");
            Console.WriteLine("222");
            i++;
            if (i>=10) 
            {
                return;
            }
            TellStory();
        }
    }
}
