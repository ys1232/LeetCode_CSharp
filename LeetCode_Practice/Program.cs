using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singly_Linked_List;

namespace LeetCode_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //new Q12.Solution().Test_Case();
            ListNode Head = new ListNode(1);
            Head.next = new ListNode(2);

            Q19.Solution new_sln = new Q19.Solution();

            ListNode_Helper.Print_Singly_Linked_List(new_sln.RemoveNthFromEnd(Head, 2));
            Console.ReadLine();
        }





    }
}
