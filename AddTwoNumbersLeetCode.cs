using System;
using System.Collections.Generic;

namespace LC_AddTwoNumbers
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        //PRINT
        public void Print()
        {
            Console.Write(val + " -> ");
            if (next != null)
            {
                next.Print();
            }
        }
    }
    public class Program
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) //Main Logic
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null && l2 != null) return l2;
            if (l1 != null && l2 == null) return l1;

            
            int carry = 0;
            int sum = l1.val + l2.val + carry;
            carry = (sum > 9) ? 1 : 0;
            var l3 = new ListNode(sum % 10);

            
            while (l1.next != null || l2.next != null)
            {
                l1 = l1.next;
                l2 = l2.next;

                var v1 = l1?.val ?? 0;
                var v2 = l2?.val ?? 0;

                sum = v1 + v2 + carry;
                carry = (sum > 9) ? 1 : 0;

                var v4 = l3.next = new ListNode(sum % 10);
                l3 = v4.next;

            }
            return l3;
        }
        static void Main(string[] args)
        {
            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
            };
            l1.next.next = new ListNode(3);
            PrintData(1, l1);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            
            PrintData(2, l2);

            var result = AddTwoNumbers(l1, l2);
            PrintData(3, result, "Result");

        }
        static void PrintData(int listNum, ListNode list, string resultlist="")
        {
            Console.WriteLine("List {0}: {1}", listNum, resultlist);
            list.Print();
            Console.WriteLine("\n");
        }
    }
}
