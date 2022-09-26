using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace test2
{
    class _111字串方法
    {
        //字串轉數組後改變其中一個字符的值
        public static void F()
        {
            //可將string 視為char的唯獨數組
            string s = "abcde";
            //也可以通過index去訪問字串中的某個字符
            Console.WriteLine(s[0]);
            //s[0] = 'b';//不可
            //首先將字串轉為char類型的數組
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //將數組轉為字串
            s = new string(chs);
        }
        //不佔內存的修改字串
        public void F2()
        {
            StringBuilder sb = new StringBuilder();//不會另外開闢內存空間
            string str = null;
            //創建一個計時器，用來記錄程序運行時間
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 10000; i++)
            {
                str += i;
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
        //字串比對(不分大小寫)
        public static void Practice()
        {
            string s = "123245678";
            Console.WriteLine(s.Length);
            string abc = "abc";
            //abc = abc.ToUpper();//轉大寫
            string ABC = "ABC";
            //ABC = ABC.ToLower();//轉小寫
            if (abc.Equals(ABC,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("StringComparison.OrdinalIgnoreCase可以忽略被比較的大小寫");
            }
        }
        //字串分割，移除不要的
        public static void Practice2()
        {
            string s = "a b    def _  +    =  ,,, fffs";
            char[] chs = { ' ', '_','+','=',',' };//想從字串移除的字符
            string[] str = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //StringSplitOptions.RemoveEmptyEntries把""移除
        }
        public static void Practice3()
        {
            string s = "2008-08-08";
            //char[] chs = { '-' };
            string[] date = s.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
