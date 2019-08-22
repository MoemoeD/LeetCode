using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 32. 最长有效括号

            //Console.WriteLine(LongestValidParentheses("(()") == 2 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")()())") == 4 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")(") == 0 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("()(())") == 6 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")()(((())))(") == 10 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")(((((()())()()))()(()))(") == 22 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("()(()") == 2 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("") == 0 ? "Yes" : "No");

            #endregion

            Console.ReadKey();
        }

        #region 32. 最长有效括号

        public static int LongestValidParentheses(string s)
        {
            char[] ac = s.ToCharArray();
            List<int> len = new List<int>();

            int leftQ = 0;
            int lent = 0;
            int lentttt = 0;

            for (int i = 0; i < ac.Length; i++)
            {
                if (ac[i] == '(')
                {
                    leftQ++;
                }
                else if (leftQ == 0)
                {
                    len.Add(lentttt);

                    lentttt = 0;
                }
                else
                {
                    leftQ--;
                    lent++;

                    if (leftQ == 0)
                    {
                        lentttt += lent;
                        lent = 0;
                        len.Add(lentttt);
                    }
                }
            }

            leftQ = 0;
            lent = 0;
            lentttt = 0;

            for (int i = ac.Length - 1; i >= 0; i--)
            {
                if (ac[i] == ')')
                {
                    leftQ++;
                }
                else if (leftQ == 0)
                {
                    len.Add(lentttt);

                    lentttt = 0;
                }
                else
                {
                    leftQ--;
                    lent++;

                    if (leftQ == 0)
                    {
                        lentttt += lent;
                        lent = 0;
                        len.Add(lentttt);
                    }
                }
            }

            len.Add(0);

            return len.Max() * 2;
        }

        #endregion
    }
}
