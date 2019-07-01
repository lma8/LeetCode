using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOver
{
    class _2_Add_Two_Numbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
              
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return new ListNode(l1.val+l2.val);
        }
    }
    
}
