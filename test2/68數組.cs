using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _68數組
    {
        //數組
        //數組類型[] 數組名=new 數組類型[數組長度];
        static void Main(string[] args)
        {
            //int[] nums = new int[10];//0
            //string[] str = new string[10];//null
            //bool[] bl = new bool[10];//false

            //int[] numsTwo = { 1, 2, 3, 4, 5 };
            //int[] numsThree = new int[3] { 1, 2, 3 };
            //int[] numsFours = new int[] { 1, 2, 3 };
            //nums[6] = 10;
            //for (int i = 0;i<nums.Length;i++)
            //{
            //    nums[i] = i + 1;
            //}

            #region 取最大和最小
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            //循環數組中的每個元素，倆倆比較
            for (int i = 0;i<nums.Length;i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            Console.WriteLine("Max:{0}, Min:{1}, Sum:{2}, Avg: {3}", max, min, sum, sum/nums.Length);
            Console.ReadKey();
            #endregion 

            #region 將數組轉成字串
            string[] names = { "jone", "Lucy", "Coco", "lulu" };
            string str = null;
            for (int i = 0;i<names.Length-1;i++)
            { 
                str += names[i]+"|";
            }
            str = str + names[names.Length - 1];
            #endregion

            #region 判斷數組中數字是否大於零
            int[] number = { 1, 12, -3, 4, -5, 6 };
            for (int i = 0;i<number.Length;i++) 
            {
                if (number[i] > 0)
                {
                    number[i] += 1;
                }
                else if (number[i] < 0)
                {
                    number[i] -= 1;
                }
                else
                {
                    nums[i] = nums[i];
                }
            }
            #endregion

            #region 反轉數組
            string[] QQ = { "I ", "am ", "a ", "good ", "person." };
            for (int i = 0;i<QQ.Length/2;i++)
            {
                string temp = QQ[i];
                QQ[i] = QQ[QQ.Length - 1 - i];
                QQ[QQ.Length - 1 - i] = temp;
            }
            for (int i = 0; i < QQ.Length; i++)
            {
                Console.WriteLine(QQ[i]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
