using System;

namespace 面對對象
{
    class Program
    {
        //類不佔內存，而對象佔內存
        static void Main(string[] args)
        {
            
            //類的實例化:將類創建一個對象  
            //對象初始化:將對象賦值
            Person zs = new Person();
            //zs._name = "張三";
            //zs._age = 23;
            //zs._gender = '男';
            zs.Name = "張三";
            zs.Age = -12;
            zs.Gender = '男';
            zs.CHLSS();
            Console.ReadKey();
        }
    }
}
