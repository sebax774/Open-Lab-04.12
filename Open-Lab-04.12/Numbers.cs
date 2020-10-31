using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int complete = i.Sum() - nums.Sum();
            return complete;
        }
    }
}