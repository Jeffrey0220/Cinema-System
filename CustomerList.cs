using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace CinemaSystem
{
    class CustomerList
    {
       
        private CListNode HeadNode;
        private int Count;
        public static int counter; //for testing

        public int COUNT
        {
            get{ return Count; }            
        }

        public CListNode HEADNODE
        {
            get { return HeadNode; }
            set { HeadNode = value; }

        }
        //adding a customer

        public void Adding(Customer x) 
        {
            if (HeadNode == null)
            {
                HeadNode=new CListNode(x);
            }
            else
            {
                HeadNode.Adding(x);               
            }

            Count++;
        }
        //removing a customer 
        public void Removing(Customer x)
        {
            CListNode temp = HEADNODE, pre = null;
            counter = 1;//for testing
            if (temp == null)
            {
                WriteLine("List is empty.");
            }
            else if(temp.ACUSTOMER.CompareTo(x)==0)
            {
                HEADNODE = temp.NEXT;
                Count--;                
            }
            else
            {
                while (temp.ACUSTOMER.CompareTo(x) != 0 && temp.NEXT != null)
                {
                    pre = temp;
                    temp = temp.NEXT;
                    counter++; //for testing
                }
                pre.NEXT = temp.NEXT;
                Count--;
            }
        }
        //count the number of customer in this list
        public void CountNum()
        {
            WriteLine($"There are {COUNT} customers in the list.");
        }
        //display all the customers' information in this list
        public void Display()
        {           
            CListNode temp = HeadNode;
            if( temp == null)
            {
                WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {

                    WriteLine(temp.ACUSTOMER.ToString());
                    temp = temp.NEXT;
                }
            }            
        }

    }
}
