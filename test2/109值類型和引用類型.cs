using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _109值類型和引用類型
    {
        //1.值類型和引用類型在內存上存儲的地方不一樣
        //值類型存儲在棧當中，引用類型存儲在堆當中
        //2.在傳遞值類型和傳遞引用類型的時候，傳遞的方式不一樣
        //值類型:int double bool char decimal struct enum
        //引用類型:string 自定義類 數組

    }
    class _110字符串
    {
        //字符串的不可變性:重新賦值後，改變的是指向的地址，舊值仍存在堆中
        //當程序結束後，GC會掃描整個內存，若發現有的空間沒有被指向，則立即銷毀
       public static void F()
        {
            string s1 = "zs";
            //s1 = "ls";
            string s2 = "zs";
            //s1和s2在堆中的地址一樣，在棧中的地址不一樣
        }
        
    }
}
