using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    class MovieQueueNode
    {
        private Movie AMovie;
        private MovieQueueNode Next;
        public static int counter2 = 0;//for testing

        public MovieQueueNode(Movie AMOVIE)
        {
            AMovie = AMOVIE;
            Next = null;
        }

        public Movie AMOVIE
        {
            get { return AMovie; }
            set { AMovie = value; }
        }

        public MovieQueueNode NEXT
        {
            get { return Next; }
            set { Next = value; }
        }
        //make a new node in the end of the queue
        public void Enqueue(Movie x)
        {
            if (Next == null)
            {
                Next = new MovieQueueNode(x);
                counter2++;//for testing
            }
            else
            {
                Next.Enqueue(x);
            }
        }
    }
}
