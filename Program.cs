using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_14_LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "12345", "1234", "12" };
            Solution s1 = new Solution();
            Console.Write(s1.LongestCommonPrefix(input));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs, int index = 0)
        {
            if (strs.Length == 0)
                return string.Empty;
            bool next = true;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length <= index || strs[i][index] != strs[0][index])
                {
                    next = false;
                    break;
                }
            }
            if (next)
                return strs[0][index] + LongestCommonPrefix(strs, index+1);
            else
                return string.Empty;
        }
    }
}
