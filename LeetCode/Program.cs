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

            //Console.WriteLine("342 + 465 = " + ResolveListNode(AddTwoNumbers(MakeListNode("342"), MakeListNode("465"))));
            //Console.WriteLine("5 + 5 = " + ResolveListNode(AddTwoNumbers(MakeListNode("5"), MakeListNode("5"))));

            #endregion

            #region 4. 寻找两个有序数组的中位数

            Console.WriteLine(FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }) == 2.0 ? "Yes" : "No");
            Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }) == 2.5 ? "Yes" : "No");

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

            #region 292. Nim 游戏

            //Console.WriteLine(CanWinNim(4) ? "Yes" : "No");

            #endregion

            #region 848. 字母移位

            //Console.WriteLine(ShiftingLetters("abc", new[] { 3, 5, 9 }) == "rpl" ? "Yes" : "No");
            //Console.WriteLine(ShiftingLetters("mkgfzkkuxownxvfvxasy", new[] { 505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513 }) == "wqqwlcjnkphhsyvrkdod" ? "Yes" : "No");

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

        #region 4. 寻找两个有序数组的中位数

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return FindMedian(nums2);
            }
            if (nums2.Length == 0)
            {
                return FindMedian(nums1);
            }

            double med1 = FindMedian(nums1);
            double med2 = FindMedian(nums2);

            if (med1 == med2)
            {
                return med1;
            }

            int[] min;
            int[] max;
            double minMed;
            double maxMed;

            if (med1 < med2)
            {
                min = nums1;
                max = nums2;
                minMed = med1;
                maxMed = med2;
            }
            else
            {
                min = nums2;
                max = nums1;
                minMed = med2;
                maxMed = med1;
            }

            int intfro = 0;
            int intbeh = 0;
            int intmaxt = 0;
            int intmint = 0;

            for (int i = 0; i <= max.Length - 1; i++)
            {
                if (max[i] <= minMed)
                {
                    intfro++;
                }
                else
                {
                    break;
                }
            }
            intmint = intfro + min.Length % 2 == 0 ? min.Length / 2 : (min.Length / 2 + 1);

            for (int i = min.Length - 1; i >= 0; i--)
            {
                if (min[i] >= maxMed)
                {
                    intbeh++;
                }
                else
                {
                    break;
                }
            }
            intmaxt = intbeh + max.Length % 2 == 0 ? max.Length / 2 : (max.Length / 2 + 1);


            return 0;
        }

        public static double FindMedian(int[] num)
        {
            if (num.Length % 2 == 0)
            {
                return (num[num.Length / 2] + num[num.Length / 2 - 1]) / 2.0;
            }
            else
            {
                return num[(num.Length - 1) / 2];
            }
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

        #region 292. Nim 游戏

        public static bool CanWinNim(int n)
        {
            return n % 4 == 0 ? false : true;
        }

        #endregion

        #region 848. 字母移位

        public static string ShiftingLetters(string S, int[] shifts)
        {
            char[] ac = S.ToCharArray();

            if (shifts.Length <= ac.Length)
            {
                int sum = 0;
                for (int i = shifts.Length - 1; i >= 0; i--)
                {
                    sum += shifts[i] % 26;
                    ac[i] = MoveS(ac[i], sum);
                }
            }
            else
            {
                int sum = 0;
                for (int i = shifts.Length - 1; i > ac.Length - 1; i--)
                {
                    sum += shifts[i] % 26;
                }

                for (int i = ac.Length - 1; i >= 0; i--)
                {
                    sum += shifts[i] % 26;
                    ac[i] = MoveS(ac[i], sum);
                }
            }

            return new string(ac);
        }

        public static char MoveS(char s, int t)
        {
            int ints = (int)s + t % 26;
            if (ints > 122)
            {
                ints = ints - 26;
            }
            return (char)ints;
        }

        #endregion
    }
}
