using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _79out參數做登入
    {
        static void Main(string[] args)
        {
            //分別提示用戶輸入名稱和密碼
            //用方法來判斷用戶輸入是否正確
            //返回給用戶一個登入結果，並且還要單獨返回給用戶一個登入訊息
            //如果用戶名錯誤，除了返回登入結果外，還要返回"用戶名錯誤"
            //"密碼錯誤"
            Console.WriteLine("請輸入用戶名");
            string userName = Console.ReadLine();
            Console.WriteLine("請輸入密碼");
            string userPwd = Console.ReadLine();
            string msg;
            bool b = IsLogin(userName, userPwd, out msg);
            Console.WriteLine("登入結果{0}", b);
            Console.WriteLine("登入訊息{0}", msg);
            Console.ReadKey();

        }
        /// <summary>
        /// 判斷登入是否成功
        /// </summary>
        /// <param name="name">用戶名</param>
        /// <param name="pwd">密碼</param>
        /// <param name="msg">登入訊息</param>
        /// <returns>bool</returns>
        public static bool IsLogin(string name, string pwd, out string msg)
        {
            //out參數在方法內部必須賦值
            if (name == "admin" && pwd == "888888")
            {
                msg = "登入成功";
                return true;
            }
            else if (name == "admin")
            {
                msg = "密碼錯誤";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "用戶名錯誤";
                return false;
            }
            else
            {
                msg = "未知錯誤";
                return false;
            }
        }
    }
}
