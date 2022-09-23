using System;
using System.Collections.Generic;
using System.Text;

namespace 靜態與非靜態
{
    public static class Student
    {
        //靜態類中只允許出現靜態成員，不允許有實例成員
        //靜態類不允許實例化
        private static string _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        public static void M1()
        {
            Console.WriteLine("Hello world");
        }
        //private int _age;//報錯
    }
}
