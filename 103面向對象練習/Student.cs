using System;
using System.Collections.Generic;
using System.Text;

namespace _103面向對象練習
{
    public class Student
    {
        //字段 屬性 方法 構造函數 析構函數
        //構造函數:
        //幫助我們初始化對象(給對象的每個屬性依次賦值)
        //構造函數是一個特殊的方法:
        //1.構造函數沒有返回值，連void也不能寫
        //2.構造函數名稱必須和類名一樣
        //3.創建對象的時候會執行構造函數
        //4.必須是public
        //5.就算沒寫構造函數，依然會自帶一個同名的構造函數(類本身會有一個默認無參的構造函數)。此默認構造函數在使用者有寫構造函數時就會被覆蓋掉。
        //5.構造函數可以重載
        //new關鍵字:
        //1.在內存開闢空間
        //2.在開闢的空間中創建對象
        //3.調用對象的構造函數進行初始化對象
        //this關鍵字:
        //1.代表當前類的對象
        //2.在類當中為 調用本類的構造函數(構造函數間互相調用) :this


        //析構函數:
        //當程序結束時 析構函數才執行
        //幫助釋放資源
        //GC Garbage Collection:幫助自動回收程序，釋放資源(但不會馬上執行，所以需要馬上釋放資源就需手動使用析構函數)
        #region 析構函數
        //~類名()
        ~Student()
        {
            Console.WriteLine("猜猜甚麼時候被調用");
        }

        #endregion

        #region 構造函數
        public Student(string name, int age, char gender, int chinese, int math, int english)
        {
            //Console.WriteLine("猜猜甚麼時候被調用");
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public Student(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Student() { }

        public Student(string name,int chinese, int math, int english) : this(name,0,'a',chinese,math,english)
        {
            //有了:this 下面全部不用寫
            //this.Name = name;
            //this.Chinese = chinese;
            //this.Math = math;
            //this.English = english;
        }
        #endregion

        #region 字段及屬性
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if(value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if(_gender!='男'&&_gender!='女')
                {
                    return _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }

        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        #endregion

        #region 方法
        public void SayHello()
        {
            Console.WriteLine("我叫{0},今年{1}歲,我是{2}生", this.Name, this.Age, this.Gender);

        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0},總成績是{1},平均成績是{2}", this.Name, (this.Chinese+this.Math+this.English), (this.Chinese + this.Math + this.English)/3);

        }
        #endregion
    }
}
