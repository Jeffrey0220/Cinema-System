using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    class ScreeningQueueNode
    {
        private Movie AMovie;
        private ScreeningQueueNode Next;
       

        public ScreeningQueueNode(Movie AMOVIE)
        {
            AMovie = AMOVIE;
            Next = null;
        }

        public Movie AMOVIE
        {
            get { return AMovie; }
            set { AMovie = value; }
        }


        public ScreeningQueueNode NEXT
        {
            get { return Next; }
            set { Next = value; }
        }

        public void Enqueue(Movie x)
        {
            if (Next == null)
            {
                Next = new ScreeningQueueNode(x);
    }
            else
            {
                Next.Enqueue(x);
            }
        }
    }
}
