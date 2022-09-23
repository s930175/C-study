//using _面向對象練習;
using System;

namespace _103面向對象練習
{
    class Program
    {
        
        //構造函數:幫助我們初始化對象(給對象的每個屬性依次賦值)
        //構造函數是一個特殊的方法:
        //1.構造函數沒有返回值，連void也不能寫
        //2.構造函數名稱必須和類名一樣
        //3.創建對象的時候會執行構造函數
        //4.必須是public
        //new關鍵字:
        //1.在內存開闢空間
        //2.在開闢的空間中創建對象
        //3.調用對象的構造函數進行初始化對象
        static void Main(string[] args)
        {
            Student zs = new Student();
            //zs.Name = "張三";
            //zs.Age = 18;
            //zs.Gender = '中';
            //zs.Chinese = 100;
            //zs.Math = 100;
            //zs.English = 100;
            //zs.SayHello();
            //zs.ShowScore();
            //有了構造函數後，裡面需傳參數
            Student zs = new Student("張三",18,'男',100,100,100);
              zs.SayHello();
              zs.ShowScore();
            Student ls = new Student("李四", 20, '女');
            Student wo = new Student("王五",60,80,100);


        }
    }
}
