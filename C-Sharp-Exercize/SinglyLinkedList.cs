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

            myList.AddFront(17);

            Console.WriteLine(myList);

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


    }
}

