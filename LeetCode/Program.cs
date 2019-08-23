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
            #region 2. 两数相加

            Console.WriteLine("342 + 465 = " + ResolveListNode(AddTwoNumbers(MakeListNode("342"), MakeListNode("465"))));
            Console.WriteLine("5 + 5 = " + ResolveListNode(AddTwoNumbers(MakeListNode("5"), MakeListNode("5"))));

            #endregion

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

        #region 2. 两数相加

        public static ListNode MakeListNode(string num)
        {
            ListNode res = null;

            MakeListNode(num, ref res);

            return res;
        }

        public static void MakeListNode(string num, ref ListNode res)
        {
            if (num == "")
            {
                return;
            }

            res = new ListNode(Convert.ToInt32(num.Substring(num.Length - 1)));

            MakeListNode(num.Substring(0, num.Length - 1), ref res.next);
        }

        public static string ResolveListNode(ListNode ln)
        {
            if (ln == null)
            {
                return "";
            }

            return ResolveListNode(ln.next) + ln.val;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null;

            Add2(l1, l2, false, ref res);

            return res;
        }

        public static void Add2(ListNode l1, ListNode l2, bool isTen, ref ListNode res)
        {
            if (l1 == null && l2 == null && !isTen)
            {
                return;
            }

            int intl1 = 0;
            int intl2 = 0;
            int intres = 0;
            int intr = 0;

            if (l1 != null)
            {
                intl1 = l1.val;
            }
            else
            {
                l1 = new ListNode(0);
            }
            if (l2 != null)
            {
                intl2 = l2.val;
            }
            else
            {
                l2 = new ListNode(0);
            }

            intres = intl1 + intl2 + (isTen ? 1 : 0);

            if (intres >= 10)
            {
                isTen = true;
                intr = intres - 10;
            }
            else
            {
                isTen = false;
                intr = intres;
            }

            res = new ListNode(intr);

            Add2(l1.next, l2.next, isTen, ref res.next);
        }

        #endregion

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
