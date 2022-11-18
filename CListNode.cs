using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class CListNode
    {
        private Customer ACustomer;
        private CListNode Next;
        public static int counter = 0;//counter for testing

        public CListNode(Customer x)
        {
            ACustomer = x;
            Next = null;
           
        }

        public Customer ACUSTOMER
        {
            get { return ACustomer; }
            set { ACustomer = value; }
        }

        public CListNode NEXT
        {
            get { return Next; }
            set { Next = value; }
        }

        //adding a new node with customer's information
        public void Adding(Customer x)
        {           
            if (Next==null)
            {
                Next=new CListNode(x);
                counter++;//counter for testing
            }
            else
            {
                Next.Adding(x);
            }
        }       
    }
}
