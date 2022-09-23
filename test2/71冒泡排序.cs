using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    class _71冒泡排序
    {
        static void Main(string[] args)
        {
            //冒泡排序:數組從大到小或從小到大排序
            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j<nums.Length-1-i; j--)
            //    {
            //        //升序排列
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //對數組進行排序(升序)
            int[] nums1 = { };
            Array.Sort(nums1);
            Array.Reverse(nums1);
        }
    }
}
