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

        //字符取代
        public static void Practice4()
        {
            string str = "33321532";
            if (str.Contains("3"))
            {
                str = str.Replace("3", "*");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
        //Substring擷取字串
        public static void Practice5()
        {
            string str = "AVFJDIYHLD";
            str = str.Substring(0);//返回原字串
            str = str.Substring(1);//VFJDIYHLD
            str = str.Substring(2,3);//FJD

            if (str.StartsWith("A"))
            {
                Console.WriteLine("這個字串從A開始");
            }
            else if (str.EndsWith("D"))
            {
                Console.WriteLine("這個字串由D結束");
            }
        }
        public static void Practice6()
        {
            string str = "ADHUIOHKUJLU";
            int index = str.IndexOf('U');//3
            int index2 = str.IndexOf('U',4);//8(從4開始找)
            int index3 = str.LastIndexOf('U');//11
            for (int i = 0; i < str.Length; i++)
            {
                str.IndexOf('U', i);
            }
        }
        //實際例子
        public static void Practice7()
        {
            string path = @"c:a\b\c\d\b\d\c\f\d.png";
            int index = path.LastIndexOf("\\");//第一個斜線為轉移符
            //取最後一個\後的東西
            path = path.Substring(index+1);
            Console.WriteLine(path);
            Console.ReadKey();
        }

        public static void Practice8()
        {
            string str = "   dfddsfwe    ";
            str = str.Trim();//移除前後的空字符
            //str = str.TrimStart();//去除前面空格
            //str = str.TrimEnd();//去除後面空格
            string str2 = null;
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("判斷是否為null或空");
            }

            string[] names = { "zs","ls","wo","xx","fds" };
            string newNames = string.Join("|",names);
            Console.WriteLine(newNames);//zs|ls|wo|xx|fds
            Console.ReadKey();
            string newNames2 = string.Join("|", "張三","李四","王五","老六");
            Console.WriteLine(newNames2);//張三|李四|王五|老六
        }
    }
}
