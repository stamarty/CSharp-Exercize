using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();

            // populate the list.
            myList.printList();
            myList.AddFront(17);
            myList.printList();
            myList.AddFront(25);
            myList.printList();
            myList.clearAll();
            myList.printList();
            Console.WriteLine("List is empty: {0}", myList.isEmpty());
            myList.AddFront(1);
            myList.printList();
            myList.AddFront(2);
            myList.printList();
            myList.AddFront(3);
            myList.printList();
            myList.AddFront(4);
            myList.printList();
            myList.printList();
            myList.AddBack(6);
            myList.printList();
            myList.AddBack(7);
            myList.printList();
            myList.AddBack(8);
            myList.printList();
            myList.AddBack(9);
            myList.printList();
            myList.DeleteFront();
            myList.printList();
            Console.WriteLine("^^ Should be one node deleted from front");
            myList.DeleteBack();
            myList.printList();
            Console.WriteLine("^^ Should be one node deleted from back");
            myList.Delete(6);
            myList.printList();
            Console.WriteLine("^^ There should not be a 6 in this most recent list.");
        }
    }

    // Student: Steven Martinez
    //
    // Genesis: The singlylinkedlist is a common data structure that consists of nodes and pointers. 
    // so I want to know how to build one. 
    //
    // Summary: Build a singly linked list and associated functions (add, delete, reverse)
    // This lesson was taught to me by Professor Mezei, I used his code when I was stuck in order to make the functions work. 

    public class Node
    {
        // create a variable of the type of data that we will hold in the linkedlist
        public int data;
        // we also need to have a way to move the pointer
        public Node Next;

        // overriding string method ToString() allows us to convert the data to string and print it
        public override string ToString()
        {
            return Convert.ToString(data);
        }

        // what data should a new node contain? 
        public Node(int newData)
        {
            this.data = newData;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        // data
        // create head pointer
        Node head;

        // methods
        
        // first we have to be able to know if the list is empty
        // return true if list is empty and false if it has nodes.
        public bool isEmpty()
        {
            if(head == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // we need to be able to empty the list.
        public void clearAll()
        {
            // if head isn't pointing at anything then the c# garbage collection empties the list
            head = null;
        }

        public void printList()
        {
            //prints out a message if the list is empty
            if (isEmpty())
            {
                Console.WriteLine("List is empty");
            }

            // point at the head of the list
            Node finger = head;
            // print each node sequentially. 
            while (finger != null)
            {
                //show what's in the node
                Console.Write(finger + " ");
                //move finger to the next node
                finger = finger.Next;
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
        }

        // let's add a node to the front of the list
        public void AddFront(int value)
        {
            // instantiate a new Node with parameters
            Node newNode = new Node(value);
            // point from newNode to head 
            newNode.Next = head;
            // point head at new node
            head = newNode;
        }

        // in case we want to add a value to the very end of the list
        public void AddBack(int value)
        {
            //instantiate the new node
            Node newNode = new Node(value);

            if (isEmpty())
            {
                head = newNode;
            }
            
            // point at the head
            Node finger = head;

            // move the pointer to the end of the list
            while (finger.Next != null)
            {
                finger = finger.Next;
            }

            finger.Next = newNode;
        }

        //TODO Delete Front
        public void DeleteFront()
        {
            // throw an exception if the list is already empty
            if (isEmpty())
            {
                throw new Exception("The list is empty, so you cannot delete a node from it.");
            }

            // assign finger to point at head
            Node finger = head;
            // move finger to the next node
            finger = finger.Next;
            // move head to where finger is. The node at the beginning will be cleaned by C# which will essentially clear out the memory.
            head = finger;
        }

        public void DeleteBack()
        {
            // again, we can't delete nodes from an empty list!
            if (isEmpty())
            {
                throw new Exception("The list is empty, so you cannot delete a node from it.");
            }

            // what if the list only has one node in it?
            else if (head.Next == null)
            {
                head = null;
            }

            else
            {
                // point at head again. 
                Node finger = head;

                // we need to traverse the list until we get to the last node. 
                while (finger.Next.Next != null)
                {
                    finger = finger.Next;
                }
                // set the final node to null
                finger.Next = null;
            }
        }

        // Delete a node with a specific value in it.
        public void Delete (int value)
        {
            // if list is empty, we cannot search it for a value
            if (isEmpty())
            {
                throw new Exception("Cannot find node in an empty list.");
            }

            // if head is the only value in the list
            else if (head.Next == null)
            {
                //check to see if data head is pointing at is the value we're looking for
                if (head.data == value)
                {
                    // if it is, set head to null, now you have an empty list
                    head = null;
                    Console.WriteLine("Your list is now empty");
                }

                // if head is the only node and head is not the value being searched for
                // tell the user the value is not in the list. 
                else
                {
                    Console.WriteLine("Value not found in list.");
                }
            }

            else
            {
                // first let's point at the head
                Node finger = head;

                while (finger.Next !=null && finger.Next.data != value)
                {
                    finger = finger.Next;
                }

                if (finger.Next != null)
                {
                    finger.Next = finger.Next.Next;
                }

                else
                {
                    Console.WriteLine("Value is not found.");
                }
                    
            }
        }
    }
}

