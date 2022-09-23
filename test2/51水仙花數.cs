using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _51水仙花數
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    Console.WriteLine("水仙花數有{0}", i);
                    }
            }
            Console.ReadKey();

            //質數練習
            for (int i = 2;i<=100;i++) 
            {
                bool b = true;//不可以定義在外面，因為每次循環皆須重新定義(全局變量不在循環裡，變不回去)
                for (int j = 2;j<=100;j++)
                {
                    //如果除的盡表示不是質數，直接跳出迴圈
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                { 
                    //b = false不是質數的不要輸出
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }

    }
}
