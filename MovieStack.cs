using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class MovieStack
    {
        private MovieStackNode Bottom;
        public static int counter1;//for testing

        public MovieStackNode BOTTOM
        {
            get { return Bottom; }
            set { Bottom = value; }
        }
        //put most recent recieved movie on the peak of the stack
        public void Push(Movie x)
        {           
            
            if (Bottom == null)
            {
                Bottom = new MovieStackNode(x);                
            }
            else
            {
                Bottom.Push(x);
            }
        }
        //receiving a new movie 
        public void ReceivingAMovie(Movie x)
        {
            Push(x);
        }
        //delect and return a movie from the peak of the stack
        public Movie Pop()
        {
            MovieStackNode temp = Bottom, pre = null;
            counter1=1;//for testing
            if (IsEmpty())
            {
                WriteLine("Movie stack is empty");
                return null;
            }           
            else if(temp.NEXT==null)
            {
                Bottom = null;
                return temp.AMOVIE;
            }
            else
            {
                while ( temp.NEXT != null)
                {
                    pre = temp;
                    temp = temp.NEXT;
                    counter1++;//for testing
                }
                pre.NEXT = temp.NEXT;
                return temp.AMOVIE;
            }
        }
        //check if the stack is empty
        public bool IsEmpty()
        {
            MovieStackNode temp = Bottom;
            if (temp == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //display all the movie in this tack
        public void Display()
        {
            MovieStackNode temp = Bottom;
            if (temp == null)
            {
                WriteLine("Movie stack is empty");
            }
            else
            {
                while (temp != null)
                {

                    WriteLine(temp.AMOVIE.ToString());
                    temp = temp.NEXT;
                }
            }
        }
    }
}
