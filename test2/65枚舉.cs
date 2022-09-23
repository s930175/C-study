using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    //聲明枚舉
    public enum Gender
    { 
        boy,
        //boy=3,
        girl
    }
    public enum QQstate
    { 
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class _65枚舉
    {
        static void Main(string[] args)
        {
            #region 將枚舉轉成int
            //變量類型 變量名=值
            //int n = 10;
            Gender gender = Gender.girl;
            //枚舉類型默認可以跟int類型互相轉換(枚舉類型和int類型兼容)
            int n = (int)gender;
            //枚舉默認從0開始，若有賦值則接續往下
            Console.WriteLine(n);//4
            Console.ReadKey();
            #endregion

            #region 將int轉成枚舉
            //將int類型強轉為枚舉類型
            int n1 = 3;
            Gender gender2 = (Gender)n1;
            Console.WriteLine(n1);//3
            Console.ReadKey();
            #endregion

            #region 將枚舉轉換成字符串類型
            //所有的類型都能轉換成string類型
            int n2 = 10;
            string s = n2.ToString();
            Gender gender3 = Gender.boy;
            string s1 = gender3.ToString();
            Console.WriteLine(s1);//boy
            Console.ReadKey();
            #endregion

            #region 將字串轉成枚舉
            //將s3轉成枚舉
            string s3 = "girl";
            //Convert.ToInt32() int.parse() int.TryParse();
            //調用parse()方法用來將字符串轉換成對應的枚舉類型
            Gender gender4 = (Gender)Enum.Parse(typeof(Gender), s3);
            Console.WriteLine(gender4);//枚舉類型的girl
            Console.ReadKey();
            //如果轉換的字符串是數字，則就算枚舉沒有也不會拋異常
            //如果轉換的字符串是文本，且枚舉中沒有，就會拋出異常
            #endregion

            Console.WriteLine("請選擇狀態:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQstate s10 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("您選擇的狀態是{0}", s10);
                    break;
                case "2":
                    QQstate s11 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("您選擇的狀態是{0}", s11);
                    break;
                case "3":
                    QQstate s12 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("您選擇的狀態是{0}", s12);
                    break;
                case "4":
                    QQstate s13 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("您選擇的狀態是{0}", s13);
                    break;
                case "5":
                    QQstate s14 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("您選擇的狀態是{0}", s14);
                    break;
            }
        }
    }
}
