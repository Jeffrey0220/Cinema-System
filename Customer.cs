using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class Customer
    {
        private string FirstName;
        private string LastName;
        private string PhoneNo;
        private string PaymentMethod;
        private int TicketCount;
        private bool FreeTicktet;                

        public string FIRSTNAME
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string LASTNAME
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string PHONENO
        {
            get { return PhoneNo; }
            set { PhoneNo = value; }
        }      

        public int TICKETCOUNT
        {
            get { return TicketCount; }
            set { TicketCount = value; }
        }

        public bool FREETICKET
        {
            get { return FreeTicktet; }
            set { FreeTicktet = value; }
        }

        public bool IsFree(int x)
        {
            if (x == 10)
            {
                TICKETCOUNT = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer(string firstname, string lastname, string phoneno, string paymentmethod)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNo = phoneno;
            PaymentMethod = paymentmethod;
            TicketCount = 0;
        }

        public Customer(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;           
        }

        //througt comparing name to search the one you want to delete
        public int CompareTo(Customer customerX)
        {
            string FullName = FirstName + LastName;
            string FullNameX = customerX.FirstName + customerX.LastName;


            if (String.Compare(FullName, FullNameX, StringComparison.CurrentCultureIgnoreCase) == 1)
            {
                return 1;
            }
            if (String.Compare(FullName, FullNameX, StringComparison.CurrentCultureIgnoreCase) == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //present customer's information
        public override string ToString()
        {
            bool res = IsFree(TICKETCOUNT);
            FreeTicktet = res;
            return $"Customer info==> *First name: {FirstName}\t *Last name: {LastName}\t *PhoneNo: {PhoneNo}\t *PaymentMethod: {PaymentMethod}\t *Ticket count: {TicketCount}\t *Free ticket: {FreeTicktet}";
        }        
    }
}
