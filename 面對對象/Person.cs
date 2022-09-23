using System;
using System.Collections.Generic;
using System.Text;

namespace 面對對象
{
    class Person
    {
        //字段
        string _name;
        //屬性:對字段的特性進行限定或再處理
        //屬性本質就是兩個方法，一個get一個set
        //使用屬性賦值，最終值依然給字段，屬性為中間過度作用
        //get判斷字段，set判斷value
        public string Name
        {
            //取值:當輸出屬性值時，會執行get方法
            get { return _name; }
            //賦值:當給屬性賦值的時候，會先執行set方法
            set { _name = value; }
        }


        int _age;

        public int Age
        {
            get { return _age; }
            set { 
                if(value<0 || value>100)
                {
                    value = 0;
                }
                _age = value; }
        }


        private char _gender;

        public char Gender
        {
            get { 
                if(_gender!='男' && _gender!='女')
                {
                    return _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }

        //非靜態方法
        public void CHLSS()
        {
            //this為當前調用者的對象
            Console.WriteLine("我是{0},我{1}歲,我是{2}生", this.Name,this.Age,this.Gender);
        }



    }
}
