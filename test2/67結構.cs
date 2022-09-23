using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    //結構:可以幫助我們一次性聲明多個不同類型的變量
    //變量在程序運行期間只能存儲一個值，而字段可以存儲多個值
    public struct Person
    {
        //字段
        public string name;
        public int age;
        public char gender;
    }
    public enum Gender
    {
        boy,
        girl
    }
    class _67結構
    {
        static void Main(string[] args)
        {
            Person zsperson;
            zsperson.name = "張三";
            zsperson.age = 21;
            zsperson.gender = Gender.boy;
            
            Person lsperson;
            lsperson.name = "李四";
            lsperson.age = 22;
            lsperson.gender = Gender.girl;
        }
    }
}
