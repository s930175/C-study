using System;

namespace 靜態與非靜態
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.M1();//實例方法(對象只能調用實例成員)
            Person.M2();//靜態方法
            //Student s = new Student();//報錯，靜態類不允許實例化
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
