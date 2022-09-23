using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _61產生隨機數
    {
        static void Main(string[] args)
        {
            ////創建能夠產生隨機樹的對象
            //Random r = new Random();
            ////調用Next方法產生隨機數，並告知要產生隨機數的範圍
            //int rNumber = r.Next(1, 11);//產生1~10的隨機數(包頭不包尾)

            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("請輸入一個姓名");
            string name = Console.ReadLine();
            switch (rNumber)
            {
                case 1:
                    Console.WriteLine("{0}上輩子是狗", name);
                    break;
                case 2:
                    Console.WriteLine("{0}上輩子是貓", name);
                    break;
                case 3:
                    Console.WriteLine("{0}上輩子是豬", name);
                    break;
                default:
                    Console.WriteLine("{0}上輩子是牛", name);
                    break;

            }
            Console.ReadKey();
        }
    }
}
