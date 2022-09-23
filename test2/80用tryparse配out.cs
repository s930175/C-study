using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _80用tryparse配out
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                //result = 0;
                return false;
            }
            
        }
    }
}
