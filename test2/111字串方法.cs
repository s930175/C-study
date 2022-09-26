using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace test2
{
    class _111字串方法
    {
        public static void F()
        {
            //可將string 視為char的唯獨數組
            string s = "abcde";
            //也可以通過index去訪問字串中的某個元素
            Console.WriteLine(s[0]);
            //s[0] = 'b';//不可
            //首先將字串轉為char類型的數組
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //將數組轉為字串
            s = new string(chs);
        }
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
                Console.WriteLine("Equals(string,StringComparison.OrdinalIgnoreCase)可以忽略被比較的大小寫");
            }
        }
        
    }
}
