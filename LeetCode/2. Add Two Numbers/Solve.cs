using System.Net;

namespace LeetCodeAndCodewars.LeetCode.N2AddTwoNumbers;

public class Solve
{
    public class ListNode : IComparable<ListNode> {
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
        
        
        public int val;
        public ListNode next;


        public static ListNode ToListNode(List<int> list)
        {
            if (list.Count == 0)
            {
                return new ListNode();
            }

            if (list.Count < 2)
            {
                return new ListNode(list[0]);
            }
            
            var headListNode = new ListNode(list[0]);
            
            var tailListNode = headListNode;
            headListNode.next = tailListNode;

            for (int i = 1; i < list.Count; i++)
            {
                tailListNode.next = new ListNode(list[i]);
                tailListNode = tailListNode.next;
            }

            return headListNode;
        }

        public int CompareTo(ListNode? other)
        {
            throw new NotImplementedException();
        }
    }



    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int numberL1 = GetNumberRevertedList(l1);
        int numberL2 = GetNumberRevertedList(l2);

        int sum = numberL1 + numberL2;

        string sumReverse = IntReverse(sum);

        ListNode result = CreateNewRevertedListNode(sumReverse);
        
        return result;
    }


    private ListNode CreateNewRevertedListNode(string value)
    {
        var headListNode = new ListNode(Convert.ToInt32(value[0].ToString()));
        
        var tailListNode = headListNode;
        headListNode.next = tailListNode;
        
        for (int i = 1; i < value.Length; i++)
        {
            tailListNode.next = new ListNode(Convert.ToInt32(value[i].ToString()));
            tailListNode = tailListNode.next;
        }

        return headListNode;
    }


    private string IntReverse(int value)
    {
        char[] valueArray = value.ToString().ToCharArray();

        string valueStr = "";

        for (int i = valueArray.Length - 1; i >= 0; i--)
        {
            valueStr += valueArray[i];
        }
        
        return valueStr;
    }


    public string StringReverse(string value)
    {
        char[] charArray = value.ToCharArray(); ;
        Array.Reverse(charArray);
        
        string result = new string(charArray);
        
        return result;
    }
    
    private int GetNumberRevertedList(ListNode node)
    {
        string str = "";

        if (node.next == null)
        {
            str = node.val.ToString();
            return Convert.ToInt32(str);
        }
        
        while (node.next != null)
        {
            str += node.val;
            node = node.next;
        }
        str += node.val;

        str = StringReverse(str);
        int number = Convert.ToInt32(str);

        return number;
    }
}