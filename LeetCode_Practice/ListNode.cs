using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }


    public class ListNode_Helper
    {
        public static void Print_Singly_Linked_List(ListNode _head)
        {
            string list_values = "";

            ListNode Node_Holder = _head;

            while (Node_Holder != null)
            {
                list_values = list_values + "-> " + Node_Holder.val;
                Node_Holder = Node_Holder.next;
            }

            list_values = list_values.Length > 0 ? list_values.Substring(3) : "";

            Console.WriteLine(list_values);
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }

    }
}
