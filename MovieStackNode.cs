using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    class MovieStackNode
    {
        private Movie AMovie;
        private MovieStackNode Next;
        public static int counter = 0;//for testing

        public MovieStackNode(Movie x)
        {
            AMovie = x;
            Next = null;
        }

        public Movie AMOVIE
        {
            get { return AMovie ; }
            set { AMovie = value; }
        }

        public MovieStackNode NEXT
        {
            get { return Next; }
            set { Next = value; }
        }
        //make a new node one the peak of the stack
        public void Push(Movie x)
        {
            if (Next == null)
            {
                Next = new MovieStackNode(x);
                counter++;//for testing
            }
            else
            {
                Next.Push(x);                
            }            
        }        
    }
}
