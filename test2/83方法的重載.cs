using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _83方法的重載
    {
        //方法的重載就是指方法名稱相同，但"參數不同"
        //若參數的個數相同，則參數的類型就不能相同
        //若參數的類型相同，則參數的個數就不能相同
        //方法的重載跟返回值沒關係
        static void Main(string[] args)
        {
            //M();//裡面參數可以傳int double string三種
        }
        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }

    }
}
