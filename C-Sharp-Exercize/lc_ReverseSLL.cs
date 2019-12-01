using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // This program will not work since I do not have ListNode or SinglyLinkedList classes
    //        // i did this specifically for leetcode.

    //    }
    //}

    // Student: Steven Martinez
    //
    // Genesis: This problem is in Leetcode.com
    // Link: https://leetcode.com/problems/reverse-linked-list/
    //
    // Summary: Reverse a singly linked list.
    //

    public class lc_ReverseSLL
    {
        // commented out because ListNode is not actually a class yet.
        //public ListNode ReverseList(ListNode head)
        //{

        //    ListNode prev = null, finger = head;

        //    // this method triggers continually until finger is pointed at a null value
        //    while (finger != null)
        //    {
        //        // be careful not to lose nodes in ListNode. 
        //        // assign finger.next to temp we're about to remove the link from head to .next
        //        // assigning temp will keep the linkedlist from falling apart
        //        ListNode temp = finger.next;

        //        // assigning finger.next to prev breaks the original pointer and points it  in the opposite direction
        //        finger.next = prev;

        //        // assign finger to previous. previous is no longer null and is now moving to the right
        //        prev = finger;

        //        // finger is now moved to the node directly to the right of where it was at the beginning of
        //        // this iteration.
        //        finger = temp;
        //    }

        //    // after the while loop has returned null for finger, the furthest right node is held 
            
        //    return prev;

        //}
    }

    // sample input:  1 -> 2 -> 3 -> 4 -> 5
    // sample output: 5 -> 4 -> 3 -> 2 -> 1

}
