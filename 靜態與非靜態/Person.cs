using System;
using System.Collections.Generic;
using System.Text;

namespace 靜態與非靜態
{
    class Person
    {
        //1.在非靜態類中，既可有實例成員，也可有靜態成員
        //2-1.在調用非靜態成員(實例成員)的時候，需使用實例對象名.非靜態成員(實例成員)名
        //2-2.在調用靜態成員的時候，需要使用類名.靜態成員名
        //總結:
        //靜態成員必須使用類明調用，實例成員使用實例化的對象名調用
        //靜態函數中，只能訪問靜態成員，不允許訪問實例成員(非靜態成員)
        //實例函數中，既可使用靜態成員，也可使用實例成員
        //靜態類中只允許有靜態成員，不允許實例成員
        //使用
        //若將類當成＂工具類＂使用，這時可以將類寫成靜態(經常使用，如console)
        //靜態類在整個項目中，資源共享

        public static string _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void M1()
        {
            //可以訪問到實例成員及靜態成員
            Console.WriteLine("我是非靜態方法");
        }
        public static void M2()
        {
            //可以訪問到靜態的字段及屬性
            Console.WriteLine("我是靜態方法");
        }
    }
}
